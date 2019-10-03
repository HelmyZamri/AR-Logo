using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using SimpleJSON;

namespace Vuforia
{
    public class TheLilacBox : VuforiaGeneric
    {
        void Start() // Use this for initialization
        {
            updateSearch("lilac", "TheLilacBox_logo");
        }


    }
}
