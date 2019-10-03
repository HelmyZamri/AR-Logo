using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using SimpleJSON;

namespace Vuforia
{
    public class BackyardTour : VuforiaGeneric
    {
        void Start() // Use this for initialization
        {
            updateSearch("backyard", "BackyardTour_logo");
        }


    }
}
