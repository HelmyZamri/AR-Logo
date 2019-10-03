using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using SimpleJSON;

namespace Vuforia
{
    public class GameTaiko : VuforiaGeneric
    {
        void Start() // Use this for initialization
        {
            updateSearch("taiko", "GameTaiko_logo");
        }


    }
}