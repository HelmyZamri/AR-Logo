using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using SimpleJSON;
using System;

namespace Vuforia
{
    public class EditScript : MonoBehaviour
    {
        string Data;
        string stringB;
        string photo;
        string markerName;
        public Transform detail;
        public Transform targetname;
        public Transform panel;
        public RawImage logoImage;
        private const string apiUrl = "https://magic.cloud.tyk.io/getAlumniStartups";
        private const string apiKey = " 59c379396070ca0001f62a00bdf5954eb28743cfb3f5785d545b0c4c";


        // Use this for initialization
        void Start()
        {
            Debug.Log("call Start");
        }


        public void updateSearch(string keyword, string pMarkerName)
        {
            Debug.Log("call updateSearch");
            markerName = pMarkerName;

            WWWForm form = new WWWForm();
            form.AddField("searchTitle", keyword);

            Dictionary<string, string> headers = form.headers;
            headers["Authorization"] = apiKey;
            byte[] rawFormData = form.data;

            WWW Start = new WWW(apiUrl, rawFormData, headers);
            StartCoroutine(WaitForRequest(Start));
        }

        IEnumerator WaitForRequest(WWW www)
        {
            Debug.Log("call WaitForRequest");
            yield return www;

            string work = www.text;
            RootObject fields = JsonUtility.FromJson<RootObject>(work);

            var parsed = JSON.Parse(www.text);

            Data = parsed["data"][0]["title"];
            stringB = parsed["data"][0]["textShortDescription"];
            photo = parsed["data"][0]["imageLogoThumbUrl"];
            StateManager sm = TrackerManager.Instance.GetStateManager();
            IEnumerable<TrackableBehaviour> tbs = sm.GetActiveTrackableBehaviours();
            foreach (TrackableBehaviour tb in tbs)
            {
                string name = tb.TrackableName;
                Debug.Log("call update " + name);

                targetname.GetComponent<Text>().text = name;
                detail.gameObject.SetActive(true);
                panel.gameObject.SetActive(true);
                logoImage.gameObject.SetActive(true);

                if (name == markerName)
                {

                    detail.GetComponent<Text>().text = Data + "\n" + stringB;
                    StartCoroutine(LoadSpriteImageFromUrl(photo));

                }
                else
                {

                }
            }
            // load photo url to the sprite
            //StartCoroutine(LoadSpriteImageFromUrl(photo));
        }

        IEnumerator LoadSpriteImageFromUrl(string URL)
        {
            Debug.Log("call LoadSpriteImageFromUrl");
            WWW www = new WWW(URL);
            while (!www.isDone)
            {
                Debug.Log("Download image on progress" + www.progress);
                yield return null;
            }

            if (!string.IsNullOrEmpty(www.error))
            {
                Debug.Log("Download failed");
            }
            else
            {
                Debug.Log("Download succes");
                Texture2D texture = new Texture2D(1, 1);
                texture.LoadImage(www.bytes);
                texture.Apply();

                logoImage.texture = texture;
            }
        }

        // Update is called once per frame
        void Update()
        {

        }

    }
}
