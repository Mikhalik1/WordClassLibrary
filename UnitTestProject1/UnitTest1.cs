using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WordClassLibrary;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        
        [DataRow(" робот боб боб строитель", 2,"боб")]
        [DataRow("Майнкрафт это  МоЯ мОя МОя жизнь ",3,"моя")]
        [DataRow("Майнкрафт это  МоЯ мОя МОя жизнь ", 3, "МОЯ")]
        public void TestMethod1(string text,int exp,string word)
        {
           
            int actual = Wordtext.WordCount(text,word);
            Assert.AreEqual(exp, actual);

        }

        [DataTestMethod]
        [DataRow("", "")]
        [DataRow("  ","  ")]
        [DataRow("                      ", "  ")]
        public void Testу(string text, string word)
        {

            Action actual =() => Wordtext.WordCount(text,word);
            Assert.ThrowsException<Exception>(actual);
        }

        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"data.xml", "String", DataAccessMethod.Sequential)]
        [DataTestMethod]
        public void TestMethod12()
        {
            string text = Convert.ToString(TestContext.DataRow["str"]);
            string word = Convert.ToString(TestContext.DataRow["word"]);
            int exp = Convert.ToInt32(TestContext.DataRow["exp"]);
            int actual = Wordtext.WordCount(text, word);
            Assert.AreEqual(exp, actual);

        }


    }
}
