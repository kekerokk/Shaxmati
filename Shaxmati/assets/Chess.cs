using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaxmati.assets
{
    abstract class Chess
    {
        private Coordinate cordinata;
        private ColorType color;

        public ColorType Color { get => color; set => color = value; }
        internal Coordinate Coordinate { get => cordinata; set => cordinata = value; }

        public Chess(ColorType color, Coordinate coordinate)
        {
            Color = color;
            Coordinate = coordinate;
        }

        public Chess()
        { }

        public void move(int x, int y)
        {
            Coordinate.X = x;
            Coordinate.Y = y;
        }

        abstract public List<Coordinate> SerchWay();



        public enum ColorType
        {
            BLACK,WHITE
        }
    }
}
