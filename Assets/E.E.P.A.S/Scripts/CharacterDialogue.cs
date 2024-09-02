using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CharacterDialogue : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI exhibitionText;
    [SerializeField] private GameObject textBox;
    [SerializeField] private Meter meter;
    [SerializeField] private Collider2D player;
    private GameObject textbox;
    [SerializeField] private string textGood;
    [SerializeField] private string textOK;
    [SerializeField] private string textBad;
    

    private void Update()
    {
        ShowText();
    }

    private void ShowText()
    {
        textBox.SetActive(true);
        exhibitionText.text = textBad;

        if (meter.MeterBar > 40)
        {
            exhibitionText.text = textGood;

        }

        else if (meter.MeterBar > 20)
        {
            exhibitionText.text = textOK;
        }
    }
}
