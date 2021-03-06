﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AssignmentASE
{      /// <summary>
/// this is class to make line in graphics
/// this class inherit the shae class
/// </summary>
    class Line : Shape
    {
        int x1, x2, y1, y2;
        /// <summary>
        /// parameter of line
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="x2"></param>
        /// <param name="y1"></param>
        /// <param name="y2"></param>

        public Line(int x1, int x2, int y1, int y2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
        }
        /// <summary>
        /// parameter of line
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        public Line(int x1, int y1)
        {
            this.x1 = x1;
            this.y1 = y1;
        }
        /// <summary>
        /// default constructor
        /// </summary>
        public Line()
        {
        }

        /// <summary>
        /// setter of line
        /// </summary>
        /// <param name="x1"></param>
        public void setX1(int x1)
        {
            this.x1 = x1;
        }
        /// <summary>
        /// getter of line
        /// </summary>
        /// <returns></returns>
        public int getX1()
        {
            return x1;
        }
        /// <summary>
        /// setter of line
        /// </summary>
        /// <param name="x2"></param>
        public void setX2(int x2)
        {
            this.x2 = x2;
        }
        /// <summary>
        /// getter if line
        /// return value of X2
        /// </summary>
        /// <returns></returns>
        public int getX2()
        {
            return x2;
        }
        /// <summary>
        /// setter for line
        /// </summary>
        /// <param name="y1"></param>
        public void setY1(int y1)
        {
            this.y1 = y1;
        }
        /// <summary>
        /// getter for line
        /// return value of Y1
        /// </summary>
        /// <returns></returns>
        public int getY1()
        {
            return y1;
        }
        /// <summary>
        /// setter of line
        /// </summary>
        /// <param name="y2"></param>
        public void setY2(int y2)
        {
            this.y2 = y2;
        }
        /// <summary>
        /// getter for line
        /// returns value of Y2
        /// </summary>
        /// <returns></returns>
        public int getY2()
        {

            return y2;
        }
        /// <summary>
        /// this method draws the line
        /// </summary>
        /// <param name="g"></param>
        /// <param name="c"></param>
        /// <param name="thickness"></param>
        public override void draw(Graphics g, Color c, int thickness)
        {
            Pen p = new Pen(c, thickness);
            g.DrawLine(p, x1, y1, x2, y2);
        }
    }
}
