﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class broadcast1 : MonoBehaviour
{
    public TextMeshProUGUI errortext;
    public TextMeshProUGUI title1;
    public TextMeshProUGUI title2;
    public TextMeshProUGUI title3;
    public TextMeshProUGUI title4;
    public TextMeshProUGUI found1;
	public TextMeshProUGUI ip1;
    public TextMeshProUGUI mdrop;
    public TextMeshProUGUI ack1;
    public TextMeshProUGUI req1;
    public TextMeshProUGUI dis1;
    public TextMeshProUGUI rec1;
    public TextMeshProUGUI rec2;
    public GameObject line1;
    public GameObject line2;
    public GameObject line3;
    public GameObject line4;
    public GameObject line5;
    public GameObject line6;
    public GameObject line7;
    public GameObject line8;
    public GameObject foundbox1;
    public GameObject ipbox2;
    public GameObject mdropbox3;
    public GameObject ackbox;
    public GameObject reqbox;
    public GameObject disbox;
    public GameObject recbox;
    public GameObject rec2box;


    // Start is called before the first frame update
    void Start()
    {
        title1.enabled = false;
        title2.enabled = false;
        title3.enabled = false;
        title4.enabled = false;
        found1.enabled = false;
        errortext.enabled = false;
		ip1.enabled = false;
        mdrop.enabled = false;
        ack1.enabled = false;
        req1.enabled = false;
        dis1.enabled = false;
        rec1.enabled = false;
        rec2.enabled = false;
        foundbox1.GetComponent<Renderer>().enabled = false;
        ipbox2.GetComponent<Renderer>().enabled = false;
        mdropbox3.GetComponent<Renderer>().enabled = false;
        ackbox.GetComponent<Renderer>().enabled = false;
        reqbox.GetComponent<Renderer>().enabled = false;
        disbox.GetComponent<Renderer>().enabled = false;
        recbox.GetComponent<Renderer>().enabled = false;
        rec2box.GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        errortext.GetComponent<TextMeshProUGUI>();
        title1.GetComponent<TextMeshProUGUI>();
        title2.GetComponent<TextMeshProUGUI>();
        title3.GetComponent<TextMeshProUGUI>();
        title4.GetComponent<TextMeshProUGUI>();
        found1.GetComponent<TextMeshProUGUI>();
		ip1.GetComponent<TextMeshProUGUI>();
        mdrop.GetComponent<TextMeshProUGUI>();
        ack1.GetComponent<TextMeshProUGUI>();
        req1.GetComponent<TextMeshProUGUI>();
        dis1.GetComponent<TextMeshProUGUI>();
        rec1.GetComponent<TextMeshProUGUI>();
        rec2.GetComponent<TextMeshProUGUI>();
        line1.GetComponent<GameObject>();
        line2.GetComponent<GameObject>();
        line3.GetComponent<GameObject>();
        line4.GetComponent<GameObject>();
        line5.GetComponent<GameObject>();
        line6.GetComponent<GameObject>();
        line7.GetComponent<GameObject>();
        line8.GetComponent<GameObject>();
        foundbox1.GetComponent<GameObject>();
        ipbox2.GetComponent<GameObject>();
        mdropbox3.GetComponent<GameObject>();
        ackbox.GetComponent<GameObject>();
        reqbox.GetComponent<GameObject>();
        disbox.GetComponent<GameObject>();
        recbox.GetComponent<GameObject>();
        rec2box.GetComponent<GameObject>();
    }

    public void broadcastClick()
    {
        errortext.GetComponent<TextMeshProUGUI>();
        title1.GetComponent<TextMeshProUGUI>();
        title2.GetComponent<TextMeshProUGUI>();
        title3.GetComponent<TextMeshProUGUI>();
        title4.GetComponent<TextMeshProUGUI>();
        found1.GetComponent<TextMeshProUGUI>();
        ip1.GetComponent<TextMeshProUGUI>();
        mdrop.GetComponent<TextMeshProUGUI>();
        ack1.GetComponent<TextMeshProUGUI>();
        req1.GetComponent<TextMeshProUGUI>();
        dis1.GetComponent<TextMeshProUGUI>();
        rec1.GetComponent<TextMeshProUGUI>();
        rec2.GetComponent<TextMeshProUGUI>();
        line1.GetComponent<GameObject>();
        line2.GetComponent<GameObject>();
        line3.GetComponent<GameObject>();
        line4.GetComponent<GameObject>();
        line5.GetComponent<GameObject>();
        line6.GetComponent<GameObject>();
        line7.GetComponent<GameObject>();
        line8.GetComponent<GameObject>();
        foundbox1.GetComponent<GameObject>();
        ipbox2.GetComponent<GameObject>();
        mdropbox3.GetComponent<GameObject>();
        ackbox.GetComponent<GameObject>();
        reqbox.GetComponent<GameObject>();
        disbox.GetComponent<GameObject>();
        recbox.GetComponent<GameObject>();
        rec2box.GetComponent<GameObject>();


        if (title1.enabled == false && title2.enabled == false && title3.enabled == false && title4.enabled == false)
        {
            title1.enabled = true;
            errortext.enabled = false;
            StartCoroutine(step1());
        }
        else
        {
            errortext.enabled = true;
        }
    }

    IEnumerator step1()
    {
        dis1.enabled = true;
        disbox.GetComponent<Renderer>().enabled = true;
        yield return new WaitForSeconds(3);
        dis1.enabled = false;
        disbox.GetComponent<Renderer>().enabled = false;
        line1.GetComponent<Renderer>().material.color = new Color(0, 1, 0);
        yield return new WaitForSeconds(.7f);
        line1.GetComponent<Renderer>().material.color = new Color(255, 255, 255);
        line2.GetComponent<Renderer>().material.color = new Color(0, 1, 0);
        yield return new WaitForSeconds(.7f);
        line2.GetComponent<Renderer>().material.color = new Color(255, 255, 255);
        line3.GetComponent<Renderer>().material.color = new Color(0, 1, 0);
        yield return new WaitForSeconds(.7f);
        line3.GetComponent<Renderer>().material.color = new Color(255, 255, 255);
        line4.GetComponent<Renderer>().material.color = new Color(0, 1, 0);
        line7.GetComponent<Renderer>().material.color = new Color(0, 1, 0);
        yield return new WaitForSeconds(.7f);
        line4.GetComponent<Renderer>().material.color = new Color(255, 255, 255);
        line7.GetComponent<Renderer>().material.color = new Color(255, 255, 255);
        line5.GetComponent<Renderer>().material.color = new Color(0, 1, 0);
        line8.GetComponent<Renderer>().material.color = new Color(0, 1, 0);
        yield return new WaitForSeconds(.7f);
        line5.GetComponent<Renderer>().material.color = new Color(255, 255, 255);
        line8.GetComponent<Renderer>().material.color = new Color(255, 255, 255);
        line6.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
        found1.enabled = true;
        foundbox1.GetComponent<Renderer>().enabled = true;
        yield return new WaitForSeconds(.7f);
        line6.GetComponent<Renderer>().material.color = new Color(255, 255, 255);
        mdrop.enabled = true;
        mdropbox3.GetComponent<Renderer>().enabled = true;
    }
}
