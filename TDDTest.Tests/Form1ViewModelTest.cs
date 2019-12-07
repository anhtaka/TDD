using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD.UI;
using Moq;

namespace TDDTest.Tests
{
    [TestClass]
    public class Form1ViewModelTest
    {
        [TestMethod]
        public void シナリオ()
        {
            var mock = new Mock<IDB>();

            mock.Setup(x => x.GetDBValue()).Returns(100);
            var viewModel = new Form1ViewModel(mock.Object);
            Assert.AreEqual("", viewModel.ATextBoxText);
            Assert.AreEqual("", viewModel.BTextBoxText);
            Assert.AreEqual("", viewModel.ResultLabelText);

            viewModel.ATextBoxText = "2";
            viewModel.BTextBoxText = "5";
            viewModel.CaluclationAction();
            Assert.AreEqual("107", viewModel.ResultLabelText);
        }
    }
    //internal class DBMock : IDB
    //{
    //    public int GetDBValue() {
    //        return 100;

    //    }
    //}
}
