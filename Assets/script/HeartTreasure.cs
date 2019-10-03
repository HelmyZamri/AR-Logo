using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using SimpleJSON;

namespace Vuforia
{
    public class HeartTreasure : VuforiaGeneric
    {
        void Start() // Use this for initialization
        {
            updateSearch("Heart", "HeartTreasure_logo");
        }


    }
}
