﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentASE
{
    public abstract class AbstractFactory
    {
        public abstract Shape getShape(String ShapeType);
    }
}