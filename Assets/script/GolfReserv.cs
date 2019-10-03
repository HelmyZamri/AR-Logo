using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using SimpleJSON;

namespace Vuforia
{
    public class GolfReserv : VuforiaGeneric
    {
        void Start() // Use this for initialization
        {
            updateSearch("Golfreserv", "GolfReserv_logo");
        }


    }
}