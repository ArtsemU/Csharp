﻿using System;

namespace Lesson8
{
    class MyString
    {

        public char[] MyCharArray { get; set; }
        private int _lenght;
        public int Length
        {
            get
            {
                return _lenght;
            }
            set
            {
                _lenght = MyCharArray.Length;
            }
        }
        public char this[int anIndex]
        {
            //Метод доступа get
            get { return MyCharArray[anIndex]; }
            //Метод доступа set
            set { MyCharArray[anIndex] = value; }
        }
        public MyString()
        {

        }
        public MyString(char[] chars)
        {
            MyCharArray = chars;
        }
        public int MyIndexOf(char findChar)
        {
            for (int i = 0; i < MyCharArray.Length; i++)
            {
                if (MyCharArray[i] == findChar)
                {
                    return i;
                }
            }
            return -1;
        }

        public int MyIndexOf(char findChar, int startPosition)
        {
            for (int i = startPosition; i < MyCharArray.Length; i++)
            {
                if (MyCharArray[i] == findChar)
                {
                    return i;
                }
            }
            return -1;
        }
        public bool IsEquals(MyString right)
        {
            if (MyCharArray.Length != right.Length)
            {
                return false;
            }
            for (int i = 0; i < MyCharArray.Length; i++)
            {
                if (MyCharArray[i] != right[i])
                {
                    return false;
                }
            }
            return true;
        }

        public MyString MyConcat(MyString ms2)
        {
            MyString newSrt = new MyString(new char[MyCharArray.Length + ms2.Length]);
            for (int i = 0; i < MyCharArray.Length; i++)
            {
                newSrt[i] = MyCharArray[i];
            }
            for (int i = MyCharArray.Length; i < ms2.Length; i++)
            {
                newSrt[i] = ms2[i];
            }
            return newSrt;
        }

        public void MyPrint()
        {
            foreach (var item in MyCharArray)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }

    }
}
