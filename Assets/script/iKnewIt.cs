using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using SimpleJSON;

namespace Vuforia
{
    public class iKnewIt : VuforiaGeneric
    {
        void Start() // Use this for initialization
        {
            updateSearch("iknewit", "iKnewIt_logo");
        }

    }
}