using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Meter;

public class Meter : MonoBehaviour
{
    private int meterMax = 50;
    private int meterBar;
    [SerializeField] private Sprite happySprite;
    [SerializeField] private Sprite okSprite;
    [SerializeField] private Sprite badSprite;
    [SerializeField] private Image actualSprite;
    public int MeterBar
    {
        get { return meterBar; }
        private set
        {
            meterBar = Mathf.Clamp(value, 0, meterMax);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DebugTest();
        CheckMeter();
    }

    private void CheckMeter()
    {
        actualSprite.sprite = badSprite;

        if (MeterBar > 40)
        {
            actualSprite.sprite = happySprite;

        }

        else if (MeterBar > 20)
        {
            actualSprite.sprite = okSprite;
        }
    }

    private void DebugTest()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            MeterBar -= 10;
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            MeterBar += 10;
        }

        Debug.Log(MeterBar);
    }
}
