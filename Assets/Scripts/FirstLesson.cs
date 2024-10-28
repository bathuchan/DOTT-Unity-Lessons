using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstLesson : MonoBehaviour
{
    public string ad = "Batuhan";
    string soyAd = "Sengul";
    public int yas = 22;
    [SerializeField]
    float pi = 3.24f;
    bool oyunDevamEdiyor=false;

    public List<string> adList = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        adList.Add("memet");
        adList.Add("asli");
        adList.Add("ferhat");

        //for(int i = 0; i<adList.Count; i++) 
        //{
        //    Debug.Log(adList[i]);
        //}

        foreach (string ad in adList) 
        {
            Debug.Log(ad);
        }

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Merhaba unity");

        //if (yas > 20 && pi == 3.14f)
        //{
        //    Debug.Log("Yasimiz 20denbuyuk");
        //}
        //else if (yas <= 10)
        //{
        //    Debug.Log("Yasimiz 10 veya 10 dan kucuk");
        //}
        //else
        //{
        //    Debug.Log("Hic bi kosul uymuyor");
        //}

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Debug.Log("space basildi");
        }

        if (Input.GetKey(KeyCode.X)) 
        {
            Debug.Log("X basildi/basiliyor");
        }


    }
}
