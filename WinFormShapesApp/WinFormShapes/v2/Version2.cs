using WinFormShapes.v2.Filling;
using WinFormShapes.v2.Moving;
using WinFormShapes.v2.Shapes;

namespace WinFormShapes
{
    public partial class Version2 : Form
    {
        Graphics graphics;
        NewMover moverNew;
        FigureParams square;
        FigureParams circle;
        FigureParams triangular;
        List<FigureParams> figuresList = new();
        bool isChecked;


        public Version2()
        {
            InitializeComponent();
            this.graphics = canvasBox.CreateGraphics();
            this.graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            moverNew = new(canvasBox.Size.Width, canvasBox.Size.Height);
        }

        private void makeSquareButton_Click(object sender, EventArgs e)
        {
            IDrawable drawer = isChecked ? new DrawFilledSquare() : new DrawSquare();
            square = new FigureParams(canvWidht: canvasBox.Size.Width, canvHeight: ClientSize.Height, drawer);
            figuresList.Add(square);
            movingTimer.Enabled = true;
        }

        private void makeCircleButton_Click(object sender, EventArgs e)
        {
            IDrawable drawer = isChecked ? new DrawFilledCircle() : new DrawCircle();
            circle = new(canvWidht: canvasBox.Size.Width, canvHeight: ClientSize.Height, drawer);
            figuresList.Add(circle);
            movingTimer.Enabled = true;
        }
        private void makeTriangularButton_Click(object sender, EventArgs e)
        {
            IDrawable drawer = isChecked ? new DrawFilledTriangle() : new DrawTriangle();
            triangular = new(canvWidht: canvasBox.Size.Width, canvHeight: ClientSize.Height, drawer);
            figuresList.Add(triangular);
            movingTimer.Enabled = true;
        }

        private void movingTimer_Tick(object sender, EventArgs e)
        {
            this.graphics = canvasBox.CreateGraphics();
            this.graphics.Clear(canvasBox.BackColor);
            moverNew.CanvWidhtMax = canvasBox.Size.Width;
            moverNew.CanvHeightMax = ClientSize.Height;

            foreach (var figure in figuresList)
            {
                figure.CurrentPosition = moverNew.Move(figure, figure.CurrentPosition);
                figure.Draw(figure, this.graphics);
            }
        }

        private void fillerBox_CheckedChanged(object sender, EventArgs e)
        {
            if (fillerBox.Checked)
            {
                isChecked = true;
            }
            else 
            { 
                isChecked = false;
            }
        }
    }
}
