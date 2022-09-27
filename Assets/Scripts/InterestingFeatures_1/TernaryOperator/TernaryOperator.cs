using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TernaryOperator 
{
    public class TernaryOperator : MonoBehaviour
    {
        private void Start()
        {
            int health = 10;
            string message;

            message = health > 0 ? "Player is Alive" : "Player is Dead";
        }
    }
}