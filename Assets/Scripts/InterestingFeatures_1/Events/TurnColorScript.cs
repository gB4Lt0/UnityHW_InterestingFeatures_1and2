using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Events 
{
    public class TurnColorScript : MonoBehaviour
    {
        private void OnEnable()
        {
            EventManager.OnClicked += TurnColor;
        }


        private void OnDisable()
        {
            EventManager.OnClicked -= TurnColor;
        }


        private void TurnColor()
        {
            Color col = new Color(Random.value, Random.value, Random.value);
            GetComponent<Renderer>().material.color = col;
        }
    }

}