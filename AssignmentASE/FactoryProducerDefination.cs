﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentASE
{     /// <summary>
/// defining factory producer class
/// </summary>
    public class FactoryProducerDefination
    {
        /// <summary>
        /// checks whether the type is shape or color
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public bool isShape(string type)
        {
            if (type == "shape")
            {
                return true;
            }
            return false;
        }
    }
}
