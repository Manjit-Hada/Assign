using System;
using AssignmentASE;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestAssignment
{
    [TestClass]
    public class VariableDefinationTest
    {
        [TestMethod]
        public void checkVariableCharacters_ifAlphabets_returnTrue()
        {
            //arrange
            VariableDefination variableDefinition = new VariableDefination();
            String word;
            bool result;

            //act
            word = "Shape";
            result = variableDefinition.isAlphabeticalVariable(word);


            //assert
            Assert.IsTrue(result);

        }
    }
}
