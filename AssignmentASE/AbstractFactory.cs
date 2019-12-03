using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentASE
{
    /// <summary>
    /// this is abstract class 
    /// It is the base class for shape factory
    /// this class also have pen declaration that can be inherited in other abstractFactory classes
    /// </summary>
    public abstract class AbstractFactory
    {
        public abstract Shape getShape(String ShapeType);
    }
}
