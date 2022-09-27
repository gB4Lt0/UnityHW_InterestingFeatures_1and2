using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Delegates 
{
    public class DelegateScript : MonoBehaviour
    {
        public delegate void MyDelegate(int num);
        MyDelegate myDelegate;


        private void Start()
        {
            myDelegate = PrintNum;
            myDelegate(50);

            myDelegate = DoubleNum;
            myDelegate(50);
        }

        private void PrintNum(int num)
        {
            print("Print Num: " + num);
        }

        private void DoubleNum(int num)
        {
            print("Double Num: " + num * 2);
        }
    }
}