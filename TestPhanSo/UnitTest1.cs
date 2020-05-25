using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestPhanSo
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestHaiPhanSoBangNhau()
        {
            PhanSo.PhanSo ps01 = new PhanSo.PhanSo(4,5);
            PhanSo.PhanSo ps02 = new PhanSo.PhanSo(-8, -10);
            bool actual = PhanSo.PhanSo.sosanh(ps01,ps02);

            bool expected = true;

            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void TestHaiPhanSoKhongBangNhau()
        {
            PhanSo.PhanSo ps01 = new PhanSo.PhanSo(4, 5);
            PhanSo.PhanSo ps02 = new PhanSo.PhanSo(5, 8);
            bool actual = PhanSo.PhanSo.sosanh(ps01, ps02);

            bool expected = false;

            Assert.AreEqual(expected, actual);
        }

        private TestContext testConText;

        public TestContext TestConText
        {
            get { return testConText; }
            set { testConText = value; }
        }


        [TestMethod]
        public void TestFile()
        {
 
        }
    }
}
