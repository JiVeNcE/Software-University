using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    class Point3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public static readonly Point3D StartingPoint = new Point3D(0, 0, 0);
        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            return String.Format(
                    "Point3D (X={0}, Y={1}, Z={2})",
                     this.X, this.Y, this.Z);
        }

        public Point3D(string[] dataPoint)
        {
            this.X = double.Parse(dataPoint[0]);
            this.Y = double.Parse(dataPoint[1]);
            this.Z = double.Parse(dataPoint[2]);
        }

        public string toDataPoint()
        {
            return String.Format("({0},{1},{2})", this.X, this.Y, this.Z);
        }

    }
}
