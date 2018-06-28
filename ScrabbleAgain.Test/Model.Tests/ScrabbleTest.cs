using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleAgain;

namespace ScrabbleAgain.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetSetUserWords_GetsSetsUserWords_StringList()
        {
            Points TestPoints = new Points();
            string testWord = "test";
            TestPoints.SetCharList(testWord);
            Assert.AreEqual(testWord, TestAnagram.GetCharList());
        }
    }
}
