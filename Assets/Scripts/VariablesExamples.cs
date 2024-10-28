using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesExamples : MonoBehaviour
{

    string isim = "Batuhan";
    string soyisim = "Şengül";
    int yas = 22;
    float boy = 175.52349f;
    bool oyunBasladimi=false;
    bool oyunBittimi=true;

    List<GameObject> oyunObjeleri=new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Tam ad: "+isim+" "+soyisim);
        //Debug.Log("Yaş: "+yas);
        //Debug.Log(yas);
        //Debug.Log("Boy:"+boy);
        //Debug.Log("Oyun Başladı mı?"+ oyunBasladimi);
        //Debug.Log(oyunBittimi?"oyun sürüyor":"oyun bitik");

        //Debug.Log(isim+isim);
        //Debug.Log(yas / 3);//buradaki çıktı ne olacak sizce?
        Debug.Log((float)yas / 5f);

        //if / if else / else yapısı

        //array/list

        //for döngüsü foreach

    }

}
