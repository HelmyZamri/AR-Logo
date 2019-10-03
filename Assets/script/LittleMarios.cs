using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using SimpleJSON;

namespace Vuforia
{
    public class LittleMarios : VuforiaGeneric
    {
        void Start() // Use this for initialization
        {
            updateSearch("Little ", "LittleMarios_logo");
        }


    }
}
