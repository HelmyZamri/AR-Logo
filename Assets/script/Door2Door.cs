using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using SimpleJSON;

namespace Vuforia
{
    public class Door2Door : VuforiaGeneric
    {
        void Start() // Use this for initialization
        {
            updateSearch("Door2Door", "Door2Door_logo");
        }


    }
}