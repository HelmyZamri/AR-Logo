﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using SimpleJSON;

namespace Vuforia
{
    public class HappyChef : VuforiaGeneric
    {
        void Start() // Use this for initialization
        {
            updateSearch("happy chef", "HappyChef_logo");
        }


    }
}