using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public int gold;
    public TMP_Text goldDisplay;

    private void Update()
    {
        goldDisplay.text = gold.ToString();
    }



}
