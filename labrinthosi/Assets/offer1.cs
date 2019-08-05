﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class offer1 : MonoBehaviour
{
    public TextMeshProUGUI errortext;
    public TextMeshProUGUI title1;
    public TextMeshProUGUI title2;
    public TextMeshProUGUI title3;
    public TextMeshProUGUI title4;


    // Start is called before the first frame update
    void Start()
    {
        title1.enabled = false;
        title2.enabled = false;
        title3.enabled = false;
        title4.enabled = false;
        errortext.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        errortext.GetComponent<TextMeshProUGUI>();
        title1.GetComponent<TextMeshProUGUI>();
        title2.GetComponent<TextMeshProUGUI>();
        title3.GetComponent<TextMeshProUGUI>();
        title4.GetComponent<TextMeshProUGUI>();
    }

    public void offerClick()
    {
        errortext.GetComponent<TextMeshProUGUI>();
        title1.GetComponent<TextMeshProUGUI>();
        title2.GetComponent<TextMeshProUGUI>();
        title3.GetComponent<TextMeshProUGUI>();
        title4.GetComponent<TextMeshProUGUI>();

        if (title1.enabled == true && title2.enabled == false && title3.enabled == false && title4.enabled == false)
        {
            title1.enabled = false;
            title2.enabled = true;
            errortext.enabled = false;
        }
        else
        {
            errortext.enabled = true;
        }
    }
}
