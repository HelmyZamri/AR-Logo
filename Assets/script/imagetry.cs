using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class imagetry : MonoBehaviour
{

    // The output of the image
    public Image img;

    // The source image
    public string url = "https://mymagic-central.s3.amazonaws.com/uploads/organization/thumbnail/345db4671d1308700e7c7949df3d62027f5484d6.adaptiveResize.80x80.png";

    IEnumerator Start()
    {
        WWW www = new WWW(url);
        yield return www;
        img.sprite = Sprite.Create(www.texture, new Rect(0, 0, www.texture.width, www.texture.height), new Vector2(0, 0));
    }
}
