using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using SimpleJSON;

namespace Vuforia
{
    public class PlayRally : VuforiaGeneric
    {
        void Start() // Use this for initialization
        {
            updateSearch("playrally", "PlayRally_logo");
        }


    }
}
