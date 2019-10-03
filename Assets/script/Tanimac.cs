using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using SimpleJSON;

namespace Vuforia
{
    public class Tanimac : VuforiaGeneric
    {
        void Start() // Use this for initialization
        {
            updateSearch("tanimac", "Tanimac_logo");
        }


    }
}