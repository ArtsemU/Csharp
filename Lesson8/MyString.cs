using System;

namespace Lesson8
{
    class MyString
    {

        public char[] MyCharArray { get; set; }

        public int MyLength
        {
            get
            {
                return MyCharArray.Length;
            }
        }
        public char this[int anIndex]
        {
            get { return MyCharArray[anIndex]; }
            set { MyCharArray[anIndex] = value; }
        }
        public MyString()
        {

        }
        public MyString(char[] chars)
        {
            MyCharArray = chars;
        }

        public int MyIndexOf(char findChar, int startPosition = 0)
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

        public int MyIndexOf(MyString subString, int startPosition = 0)
        {

            for (int i = startPosition; i < MyCharArray.Length - subString.MyLength; i++)
            {
                int count = 0;
                for (int j = 0; j < subString.MyLength; j++)
                {

                    if (MyCharArray[i + j] != subString[j])
                    {
                        break;
                    }
                    else
                    {
                        count++;
                    }
                }
                if (count == subString.MyLength)
                {
                    return i;
                }
            }
            return -1;
        }

        public bool IsEquals(MyString right)
        {
            if (MyCharArray.Length != right.MyLength)
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
            MyString newSrt = new MyString(new char[MyCharArray.Length + ms2.MyLength]);
            for (int i = 0; i < MyCharArray.Length; i++)
            {
                newSrt[i] = MyCharArray[i];
            }
            for (int i = MyCharArray.Length; i < ms2.MyLength; i++)
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
