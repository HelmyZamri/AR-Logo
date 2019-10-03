using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using SimpleJSON;

namespace Vuforia
{
    public class SimiCart : VuforiaGeneric
    {
        void Start() // Use this for initialization
        {
            updateSearch("simicart", "SimiCart_logo");
        }


    }
}