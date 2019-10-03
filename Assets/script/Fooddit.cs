using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using SimpleJSON;

namespace Vuforia
{
    public class Fooddit : VuforiaGeneric
    {
        void Start() // Use this for initialization
        {
            updateSearch("Fooddit", "Fooddit_logo");
        }


    }
}