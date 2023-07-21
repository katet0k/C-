using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class Point3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double DistanceTo(Point3D otherPoint)
        {
            double dx = X - otherPoint.X;
            double dy = Y - otherPoint.Y;
            double dz = Z - otherPoint.Z;

            return Math.Sqrt(dx * dx + dy * dy + dz * dz);
        }
    }
}
