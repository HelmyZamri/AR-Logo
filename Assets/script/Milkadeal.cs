using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using SimpleJSON;

namespace Vuforia
{
    public class Milkadeal : VuforiaGeneric
    {
        void Start() // Use this for initialization
        {
            updateSearch("Milk A Deal", "Milkadeal_logo");
        }


    }
}