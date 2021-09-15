using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaxmati.assets
{
    class Pawn : Chess
    {
        public Pawn()
        {
            Coordinate = new Coordinate();
        } 

        public override List<Coordinate> SerchWay()
        {
            List<Coordinate> result = new();
            if(Color == ColorType.WHITE)
            {
                result.Add(new Coordinate(Coordinate.X, Coordinate.Y + 1));
                result.Add(new Coordinate(Coordinate.X + 1, Coordinate.Y + 1));
                result.Add(new Coordinate(Coordinate.X - 1, Coordinate.Y + 1));

            }
            else
            {
                result.Add(new Coordinate(Coordinate.X, Coordinate.Y - 1));
                result.Add(new Coordinate(Coordinate.X + 1, Coordinate.Y - 1));
                result.Add(new Coordinate(Coordinate.X - 1, Coordinate.Y - 1));

            }


            return result;
        }
    }
}
