using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD.UI;

namespace TDDTest.Tests
{
    [TestClass]
    public class Form1ViewModelTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var viewModel = new Form1ViewModel();
            Assert.AreEqual("", viewModel.ATextBoxText);
            Assert.AreEqual("", viewModel.BTextBoxText);
            Assert.AreEqual("", viewModel.ResultLabelText);

            viewModel.ATextBoxText = "2";
            viewModel.BTextBoxText = "5";
            viewModel.CaluclationAction();
            Assert.AreEqual("7", viewModel.ResultLabelText);
        }
    }
}
