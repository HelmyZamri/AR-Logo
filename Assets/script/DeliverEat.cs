using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using SimpleJSON;

namespace Vuforia
{
    public class DeliverEat : VuforiaGeneric
    {
        void Start() // Use this for initialization
        {
            updateSearch("delivereat", "DeliverEat_logo");
        }


    }
}
