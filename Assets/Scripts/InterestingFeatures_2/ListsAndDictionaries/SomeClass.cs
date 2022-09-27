using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace ListsAndDictionaries 
{
    using UnityEngine;
    using System.Collections;
    using System.Collections.Generic;

    public class SomeClass : MonoBehaviour
    {
        private void Start()
        {

            List<BadGuy> badguys = new List<BadGuy>();

            badguys.Add(new BadGuy("Harvey", 50));
            badguys.Add(new BadGuy("Magneto", 100));
            badguys.Add(new BadGuy("Pip", 5));

            badguys.Sort();

            foreach (BadGuy guy in badguys)
            {
                print(guy.name + " " + guy.power);
            }

            badguys.Clear();
        }
    }
}