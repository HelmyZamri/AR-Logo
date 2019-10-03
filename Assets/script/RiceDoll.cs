using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using SimpleJSON;

namespace Vuforia
{
    public class RiceDoll : VuforiaGeneric
    {
        void Start() // Use this for initialization
        {
            updateSearch("rice doll", "ricedoll_logo");
        }


    }
}
