﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble;

namespace ScrabbleAgain.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetSetUserWords_GetsSetsUserWords_CharList()
        {
            Points testPoints = new Points();
            char[] testWord = { 't' };
            testPoints.SetCharList(testWord);
            Assert.AreEqual(testWord, testPoints.GetCharList());
        }

        [TestMethod]
        public void GetSetUserWords_GetsSetsUserWords_StringList()
        {
            Points testPoints = new Points();
            string testWord = "hello";
            testPoints.SetInput(testWord);
            Assert.AreEqual(testWord, testPoints.GetInput());
        }

        [TestMethod]
        public void GetSetUserWords_GetsSetsUserWords_IntList()
        {
            Points testPoints = new Points();
            int intPoint = 1;
            testPoints.SetIntList(intPoint);
            Assert.AreEqual(intPoint, testPoints.GetIntList());
        }
    }
}
