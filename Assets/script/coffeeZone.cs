using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using SimpleJSON;

namespace Vuforia
{
    public class coffeeZone : VuforiaGeneric
    {
        void Start() // Use this for initialization
        {
            updateSearch("coffeezone", "coffee_logo");
        }

        
    }
}