using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AssignmentASE
{    /// <summary>
/// this is class to make polygon in graphics
/// this class inherit the shape class
/// </summary>
    public class Polygon : Shape
    {      /// <summary>
          /// default constructor
         /// </summary>
        public Polygon()
        {

        }
        /// <summary>
        /// get and set values of polygon
        /// </summary>
        public PointF[] polygon_vertices { get; set; }
        /// <summary>
        /// this method draws the polygon
        /// </summary>
        /// <param name="g"></param>
        /// <param name="c"></param>
        /// <param name="thickness"></param>
        public override void draw(Graphics g, Color c, int thickness)
        {
            Pen p = new Pen(Color.Green, thickness);
            g.DrawPolygon(p, polygon_vertices);
        }
    }
}
