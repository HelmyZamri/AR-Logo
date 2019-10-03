using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class Tryapi : MonoBehaviour
{
  
    void Start()
    {
        StartCoroutine(Upload());
    }

    IEnumerator Upload()
    {
        WWWForm form = new WWWForm();
        form.AddField("title", "MUN 2019 perkasa aktiviti keusahawanan negara");

        using (UnityWebRequest www = UnityWebRequest.Post("https://magic.cloud.tyk.io/getMagicWpLatestNews", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log("Form upload complete!");
            }
        }
    }

}