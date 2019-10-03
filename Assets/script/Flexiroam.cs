using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using SimpleJSON;

namespace Vuforia
{
    public class Flexiroam : VuforiaGeneric
    {
        void Start() // Use this for initialization
        {
            updateSearch("flexiroam", "FlexiRoam_logo");
        }


    }
}
