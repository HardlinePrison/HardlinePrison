using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormShapes.v2.Shapes;

namespace WinFormShapes.v2.Moving
{
    class NewMover
    {
        public int CanvWidhtMax { get; set; }
        public int CanvHeightMax { get; set; }

        public NewMover(int canvWidhtMax, int canvHeightMax)
        {
            CanvWidhtMax = canvWidhtMax;
            CanvHeightMax = canvHeightMax;
        }

        public Point Move(FigureParams figure, Point coord)
        {
            if (figure.SpeedX > 0)
            {
                if (coord.X + figure.WidhtFigure >= CanvWidhtMax)
                {
                    figure.SpeedX *= -1;
                }
            }
            else
            {
                if (coord.X <= 0)
                {
                    figure.SpeedX = Math.Abs(figure.SpeedX);
                }
            }

            if (figure.SpeedY > 0)
            {
                if (coord.Y + figure.HeightFigure >= CanvHeightMax)
                {
                    figure.SpeedY *= -1;
                }
            }
            else
            {
                if (coord.Y <= 0)
                {
                    figure.SpeedY = Math.Abs(figure.SpeedY);
                }
            }

            coord.X += figure.SpeedX;
            coord.Y += figure.SpeedY;
            return coord;
        }
    }
}
