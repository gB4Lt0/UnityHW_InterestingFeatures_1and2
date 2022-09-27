using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Delegates 
{
    public class MulticastScript : MonoBehaviour
    {
        public delegate void MultiDelegate();
        MultiDelegate myMultiDelegate;


        private void Start()
        {
            myMultiDelegate += PowerUp;
            myMultiDelegate += TurnRed;

            if (myMultiDelegate != null)
            {
                myMultiDelegate();
            }
        }

        private void PowerUp()
        {
            print("Orb is powering up!");
        }

        private void TurnRed()
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
    }
}