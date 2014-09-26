using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    class Path3D
    {
        private List<Point3D> path;
        public Path3D() : this(new List<Point3D>()) { }

        public Path3D(List<Point3D> path)
        {
            this.Path = path;
        }

        public List<Point3D> Path
        {
            get { return this.path; }
            set
            {
                this.path = value;
            }
        }

        public void addPointToPath(Point3D point)
        {
            this.Path.Add(point);
        }

        public override string ToString()
        {
            StringBuilder pathData = new StringBuilder();
            foreach (var p in this.Path)
            {
                pathData.Append(p.toDataPoint());

            }
            return pathData.ToString();
        }
    }
}
