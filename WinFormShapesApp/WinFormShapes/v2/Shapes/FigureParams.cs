using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WinFormShapes.v2.Filling;

namespace WinFormShapes.v2.Shapes
{
    public class FigureParams : IDrawable
    {
        private readonly Random random = new();
        private Color color;
        private IDrawable drawer;



        public FigureParams(int canvWidht, int canvHeight, IDrawable drawer)
        {
            ///
            //rndom size
            ///
            WidhtFigure = random.Next(30, 100);
            HeightFigure = WidhtFigure;
            ///
            //rndom point 
            ///
            CurrentPosition = new Point(random.Next(0, canvWidht - WidhtFigure), random.Next(0, canvHeight - HeightFigure));
            ///
            //rndom color
            ///
            color = Color.FromArgb(random.Next(100, 255), random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));

            FigureDrawColor = new Pen(color, random.Next(1, 4));
            FigureFillColor = new SolidBrush(color);
            ///
            //rndom speed
            ///
            SpeedX = random.Next(-5, 5);
            SpeedY = random.Next(-5, 5);
            if (SpeedX + SpeedY == 0)
            {
                SpeedX = random.Next(-5, 5);
            }
            ///
            //accepting figure drawer
            ///
            this.drawer = drawer;
        }
        public int SpeedX { get; set; }
        public int SpeedY { get; set; }
        public int WidhtFigure { get; }
        public int HeightFigure { get; }
        public Pen Pen { get; protected set; }
        public Point CurrentPosition { get; set; }
        public Pen FigureDrawColor { get; }
        public SolidBrush FigureFillColor { get;}

        public void Draw(FigureParams figure, Graphics graphics)
        {
            drawer.Draw(figure, graphics);
        }

    }
}

