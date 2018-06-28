using System;
using System.Collections.Generic;

namespace Scrabble
{

    public class Points
    {
        private string _input;
        private char[] _charList;
        private int _intList;

        public void SetInput(string word)
        {
            _input = word;
        }

        public string GetInput()
        {
            return _input;
        }

        public void SetCharList(char[] a)
        {
            _charList = a;
        }

        public char[] GetCharList()
        {
            return _charList;
        }

        public void SetIntList(int one)
        {
            _intList = one;
        }

        public int GetIntList()
        {
            return _intList;
        }


        public static Dictionary<char, int> charPoints = new Dictionary<char, int>() { { 'a', 1 }, { 'e', 1 }, { 'i', 1 }, { 'o', 1 }, { 'u', 1 }, { 'l', 1 }, { 'n', 1 }, { 'r', 1 }, { 's', 1 }, { 't', 1 }, { 'd', 2 }, { 'g', 2 }, { 'b', 3 }, { 'c', 3 }, { 'm', 3 }, { 'p', 3 }, { 'f', 4 }, { 'h', 4 }, { 'v', 4 }, { 'w', 4 }, { 'y', 4 }, { 'k', 5 }, { 'j', 8 }, { 'x', 8 }, { 'q', 10 }, { 'z', 10 } };

        //public void UserWord();
            //{
                
            //}




            //static void Main()
            //{
            //    //nothing here yet
            //}
        }
    }