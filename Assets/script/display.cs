using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SimpleJSON;

public class display : MonoBehaviour
{

    private const string URL = "https://magic.cloud.tyk.io/getMagicWpLatestNews";
    private const string API = " 59c379396070ca0001f62a00bdf5954eb28743cfb3f5785d545b0c4c";

    public Text responseText;

    public void Request()
    {
        WWWForm form = new WWWForm();

        Dictionary<string, string> headers = form.headers;
        headers["Authorization"] = API;

        WWW request = new WWW(URL, null, headers);
        StartCoroutine(OnReponse(request));
    }



    private IEnumerator OnReponse(WWW req)
    {
        yield return req;

        responseText.text = req.text;
        //Debug.Log("yoyo");
        var parsed = JSON.Parse(req.text);
        Debug.Log(parsed["status"].Value);
        Debug.Log(parsed["data"][0]["title"].Value);


        for (var i = 0; i < 10; i++)
        {
            Debug.Log(parsed["data"][i]["title"].Value);
        }

        //GetComponent<TextMesh>().text = " \n " + (parsed["data"]) + ",\n " + (parsed["title"]);
    }
}
