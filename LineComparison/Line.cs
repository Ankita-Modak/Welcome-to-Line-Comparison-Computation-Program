using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LineComparison
{
    internal class Line : IComparable<Line>
    {
        private readonly double x1, y1, x2, y2;
        private readonly double length;

        public Line(double x1, double y1, double x2, double y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            length = CalculateLength();
        }

        private double CalculateLength()
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        public int CompareTo(Line other)
        {
            return length.CompareTo(other.length);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Line other = (Line)obj;
            return (x1 == other.x1 && y1 == other.y1 && x2 == other.x2 && y2 == other.y2) ||
                   (x1 == other.x2 && y1 == other.y2 && x2 == other.x1 && y2 == other.y1);
        }

        public override int GetHashCode()
        {
            return Tuple.Create(x1, y1, x2, y2).GetHashCode();
        }
    }
}

