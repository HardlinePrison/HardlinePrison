using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormShapes.v2.Shapes;

namespace WinFormShapes.v2.Filling
{

    public interface IDrawable
    {
        void Draw(FigureParams figure, Graphics graphics);
    }



    public class DrawSquare : IDrawable
    {
        public void Draw(FigureParams figure, Graphics graphics)
        {
            graphics.DrawRectangle(figure.FigureDrawColor, figure.CurrentPosition.X, figure.CurrentPosition.Y,
                                   figure.WidhtFigure, figure.HeightFigure);


        }
    }

    public class DrawFilledSquare : IDrawable
    {
        public void Draw(FigureParams figure, Graphics graphics)
        {
            graphics.FillRectangle(figure.FigureFillColor, figure.CurrentPosition.X, figure.CurrentPosition.Y,
                                   figure.WidhtFigure, figure.HeightFigure);


        }
    }

    public class DrawCircle : IDrawable
    {
        public void Draw(FigureParams figure, Graphics graphics)
        {
            graphics.DrawEllipse(figure.FigureDrawColor, figure.CurrentPosition.X, figure.CurrentPosition.Y,
                                 figure.WidhtFigure, figure.HeightFigure);
        }
    }

    public class DrawFilledCircle : IDrawable
    {
        public void Draw(FigureParams figure, Graphics graphics)
        {
            graphics.FillEllipse(figure.FigureFillColor, figure.CurrentPosition.X, figure.CurrentPosition.Y,
                                   figure.WidhtFigure, figure.HeightFigure);


        }
    }


    public class DrawTriangle : IDrawable
    {
        public void Draw(FigureParams figure, Graphics graphics)
        {
            Point[] points = new Point[3];

            points[0] = new Point(figure.CurrentPosition.X + figure.WidhtFigure / 2, figure.CurrentPosition.Y);
            points[1] = new Point(points[0].X - figure.WidhtFigure / 2, points[0].Y + figure.WidhtFigure);
            points[2] = new Point(points[0].X + figure.WidhtFigure / 2, points[0].Y + figure.WidhtFigure);

            graphics.DrawPolygon(figure.FigureDrawColor, points);
        }
    }

    public class DrawFilledTriangle : IDrawable
    {
        public void Draw(FigureParams figure, Graphics graphics)
        {
            Point[] points = new Point[3];

            points[0] = new Point(figure.CurrentPosition.X + figure.WidhtFigure / 2, figure.CurrentPosition.Y);
            points[1] = new Point(points[0].X - figure.WidhtFigure / 2, points[0].Y + figure.WidhtFigure);
            points[2] = new Point(points[0].X + figure.WidhtFigure / 2, points[0].Y + figure.WidhtFigure);

            graphics.FillPolygon(figure.FigureFillColor, points);
        }
    }
}
