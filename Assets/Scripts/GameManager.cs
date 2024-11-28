using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int point = 0;
    [SerializeField] private TextMeshProUGUI textMeshPro;

    private void Update()
    {
        textMeshPro.text = point.ToString();
    }
}
