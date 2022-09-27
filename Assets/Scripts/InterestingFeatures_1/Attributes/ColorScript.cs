using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Attributes 
{
    [ExecuteInEditMode]
    public class ColorScript : MonoBehaviour
    {
        private void Start()
        {
            GetComponent<Renderer>().sharedMaterial.color = Color.cyan;
        }
    }

}
