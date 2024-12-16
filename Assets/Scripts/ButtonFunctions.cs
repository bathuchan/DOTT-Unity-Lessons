using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonFunctions : MonoBehaviour
{
   
    public void StartNewGame() 
    {
        SceneManager.LoadScene("SampleScene");
    }
}
