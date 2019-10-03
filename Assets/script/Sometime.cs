using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using SimpleJSON;

namespace Vuforia
{
    public class Sometime : VuforiaGeneric
    {
        void Start() // Use this for initialization
        {
            updateSearch("sometime", "sometime_logo");
        }


    }
}