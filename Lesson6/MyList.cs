using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Lesson6
{
    class MyList
    {
        public List<string> myList;
        Random random = new Random();
        public MyList()
        {
            myList = new List<string>();
        }

        public void AddOneItem(string str)
        {
            myList.Add(str);
        }
        public void DeleteLastItem()
        {
            myList.RemoveAt(myList.Count - 1);
        }
        public void DeleteFirstItem()
        {
            myList.RemoveAt(0);
        }
        public string GetAndDeleteRandomItem()
        {
            int randomIndex = random.Next(0, myList.Count - 1);
            string removeValue = myList[1];
            myList.RemoveAt(randomIndex);
            return removeValue;
        }
    }
}
