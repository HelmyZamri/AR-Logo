using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using SimpleJSON;

namespace Vuforia
{
    public class AshokaGroup : VuforiaGeneric
    {
        void Start() // Use this for initialization
        {
            updateSearch("ashoka", "ashoka_logo");
        }


    }
}
