using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using SimpleJSON;

namespace Vuforia
{
    public class Foodabox : VuforiaGeneric
    {
        void Start() // Use this for initialization
        {
            updateSearch("foodabox", "FoodABox_logo");
        }


    }
}
