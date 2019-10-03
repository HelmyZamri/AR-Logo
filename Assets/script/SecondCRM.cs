using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using SimpleJSON;

namespace Vuforia
{
    public class SecondCRM : VuforiaGeneric
    {
        void Start() // Use this for initialization
        {
            updateSearch("Second", "SecondCRM_logo");
        }


    }
}