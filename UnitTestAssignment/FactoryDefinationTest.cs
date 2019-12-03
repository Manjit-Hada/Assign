using System;
using AssignmentASE;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestAssignment
{
    [TestClass]
    public class FactoryDefinationTest
    {
        [TestMethod]
        public void isShape()
        {
            //assign
            bool result;
            String type;
            FactoryProducerDefination fp = new FactoryProducerDefination();

            //act
            type = "shape";
            result = fp.isShape(type);

            //assert
            Assert.IsTrue(result);
        }
    }
}
