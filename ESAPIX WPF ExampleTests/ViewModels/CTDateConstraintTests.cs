using Microsoft.VisualStudio.TestTools.UnitTesting;
using ESAPX_StarterUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESAPIX.Constraints;

namespace ESAPX_StarterUI.ViewModels.Tests
{
    [TestClass()]
    public class CTDateConstraintTests
    {
        [TestMethod()]
        public void CTDateFailsCorrectly()
        {

            //Arrange
            var ctDate = DateTime.Now.AddDays(-61);
            //Act
            var actual = new CTDateConstraint().ConstraintCTDate(ctDate).ResultType;
            //Assert
            var expected = ResultType.ACTION_LEVEL_3;

            Assert.AreEqual(expected, actual);


        }
        [TestMethod()]
        public void CTDatePassesCorrectly()
        {

            //Arrange
            var ctDate = DateTime.Now.AddDays(-40);
            //Act
            var actual = new CTDateConstraint().ConstraintCTDate(ctDate).ResultType;
            //Assert
            var expected = ResultType.ACTION_LEVEL_1;

            Assert.AreEqual(expected, actual);
        }
    }
}