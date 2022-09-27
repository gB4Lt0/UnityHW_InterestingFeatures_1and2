using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Attributes 
{
    public class SpinScript : MonoBehaviour
    {
        [Range(-100, 100)] public int speed = 0;

        private void Update()
        {
            transform.Rotate(new Vector3(0, speed * Time.deltaTime, 0));
        }
    }
}
