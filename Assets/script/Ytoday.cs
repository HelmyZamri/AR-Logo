using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using SimpleJSON;

namespace Vuforia
{
    public class Ytoday : VuforiaGeneric
    {
        void Start() // Use this for initialization
        {
            updateSearch("ytoday", "Ytoday_logo");
        }


    }
}
