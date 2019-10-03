using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class imageloader : MonoBehaviour
{

    public RawImage img;

    void Awake()
    {
        img = this.gameObject.GetComponent<RawImage>();
    }

    // Use this for initialization
    IEnumerator Start()
    {
        WWW www = new WWW("https://mymagic-central.s3.amazonaws.com/uploads/organization/thumbnail/345db4671d1308700e7c7949df3d62027f5484d6.adaptiveResize.80x80.png");
        yield return www;
        Texture2D te = www.texture;
        img.texture = te;
        //img.SetNativeSize();
    }

    // Update is called once per frame
    void Update()
    {

    }
}