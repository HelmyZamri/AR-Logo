using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using SimpleJSON;

namespace Vuforia
{
    public class Cloudjet : VuforiaGeneric
    {
        void Start() // Use this for initialization
        {
            updateSearch("cloudjet ", "Cloudjet_logo");
        }


    }
}