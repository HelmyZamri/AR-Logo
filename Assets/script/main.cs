using UnityEngine;
using System.Collections;
using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.UI;
using SimpleJSON;


public class main : MonoBehaviour
{
    string JSON_title;
    string JSON_textShortDescription;
    public Transform targetname;
    public Text details;



    string Zero;
    //WWW www;
    private const string URL = "https://magic.cloud.tyk.io/getAlumniStartups";
    private const string API = " 59c379396070ca0001f62a00bdf5954eb28743cfb3f5785d545b0c4c";
    string url = "https://magic.cloud.tyk.io/getAlumniStartups";




    void Start() // Use this for initialization
    {
        WWWForm form = new WWWForm();
        form.AddField("searchTitle", "coffeezone");


        Dictionary<string, string> headers = form.headers;
        headers["Authorization"] = API;
        byte[] searchTitle = form.data;

        WWW Start = new WWW(url, searchTitle, headers);
        StartCoroutine(WaitForRequest(Start));



    }

    IEnumerator WaitForRequest(WWW www)
    {
        yield return www;




        // check for errors
        if (www.error == null)
        {
            string work = www.text;
            RootObject fields = JsonUtility.FromJson<RootObject>(work);

            //JSON_title = fields.data;
            //JSON_htmlContent = fields.htmlContent;
            var parsed = JSON.Parse(www.text);
            string event_id = "1743";
            for (var i = 0; i < parsed["data"].Children.Count(); i++)
            {

            if (parsed["data"][i]["id"].Value == event_id)
            {
                  Update(parsed["data"][i]["title"], parsed["data"][i]["textShortDescription"]);
            }
            else
            {

            }

            }
            Debug.Log(parsed["data"][0]["title"].Value);
        } 
    }
    //Update is called once per frame
    void Update(string JSON_title,string JSON_textShortDescription)
    {

        GetComponent<Text>().text= " \n " + JSON_title + ",\n " + JSON_textShortDescription + "\n";


    //Debug.Log(JSON_title);
    //Debug.Log(JSON_textShortDescription);

    }

    public class Datum
    {
        public string id;
        public string guid;
        public string slug;
        public string datePosted;
        public string gmtDatePosted;
        public string title;
        public string htmlContent;
        public string imageCoverSourceUrl;
        public string imageCoverThumbUrl;
    }

    public class RootObject
    {
        public string id;
        public string code;
        public object slug;
        public string title;
        public object textOneliner;
        public object textShortDescription;
        public object htmlContent;
        public object legalformId;
        public object companyNumber;
        public string imageLogo;
        public string imageLogoThumbUrl;
        public string imageLogoUrl;
        public object urlWebsite;
        public object emailContact;
        public object yearFounded;
        public object timezone;
        public int isActive;
        public string dateAdded;
        public string fDateAdded;
        public string dateModified;
        public string fDateModified;
        public object legalName;
        public object fullAddress;
        public object addressline1;
        public object addressLine2;
        public object addressZip;
        public object addressCity;
        public object addressState;
        public object addressCountryCode;
        public object latlong_address;
        public string lat;
        public string lng;
    }


}

