﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using SimpleJSON;

namespace Vuforia
{
    public class TNLP : VuforiaGeneric
    {
        void Start() // Use this for initialization
        {
            updateSearch("nasi", "TNLP_logo");
        }


    }
}
