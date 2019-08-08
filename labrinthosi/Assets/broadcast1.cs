using System.Collections;
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
    public GameObject line1;
    public GameObject line2;
    public GameObject line3;
    public GameObject line4;
    public GameObject line5;
    public GameObject line6;
    public GameObject line7;
    public GameObject line8;
    public GameObject box1;
    public GameObject box2;
    public GameObject box3;


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
        box1.GetComponent<Renderer>().enabled = false;
        box2.GetComponent<Renderer>().enabled = false;
        box3.GetComponent<Renderer>().enabled = false;
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
        line1.GetComponent<GameObject>();
        line2.GetComponent<GameObject>();
        line3.GetComponent<GameObject>();
        line4.GetComponent<GameObject>();
        line5.GetComponent<GameObject>();
        line6.GetComponent<GameObject>();
        line7.GetComponent<GameObject>();
        line8.GetComponent<GameObject>();
        box1.GetComponent<GameObject>();
        box2.GetComponent<GameObject>();
        box3.GetComponent<GameObject>();
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
        line1.GetComponent<GameObject>();
        line2.GetComponent<GameObject>();
        line3.GetComponent<GameObject>();
        line4.GetComponent<GameObject>();
        line5.GetComponent<GameObject>();
        line6.GetComponent<GameObject>();
        line7.GetComponent<GameObject>();
        line8.GetComponent<GameObject>();
        box1.GetComponent<GameObject>();
        box2.GetComponent<GameObject>();
        box3.GetComponent<GameObject>();


        if (title1.enabled == false && title2.enabled == false && title3.enabled == false && title4.enabled == false)
        {
            title1.enabled = true;
            errortext.enabled = false;
            StartCoroutine(changeColour());
        }
        else
        {
            errortext.enabled = true;
        }
    }

    IEnumerator changeColour()
    {
        line1.GetComponent<Renderer>().material.color = new Color(0, 1, 0);
        yield return new WaitForSeconds(.5f);
        line1.GetComponent<Renderer>().material.color = new Color(255, 255, 255);
        line2.GetComponent<Renderer>().material.color = new Color(0, 1, 0);
        yield return new WaitForSeconds(.5f);
        line2.GetComponent<Renderer>().material.color = new Color(255, 255, 255);
        line3.GetComponent<Renderer>().material.color = new Color(0, 1, 0);
        yield return new WaitForSeconds(.5f);
        line3.GetComponent<Renderer>().material.color = new Color(255, 255, 255);
        line4.GetComponent<Renderer>().material.color = new Color(0, 1, 0);
        line7.GetComponent<Renderer>().material.color = new Color(0, 1, 0);
        yield return new WaitForSeconds(.5f);
        line4.GetComponent<Renderer>().material.color = new Color(255, 255, 255);
        line7.GetComponent<Renderer>().material.color = new Color(255, 255, 255);
        line5.GetComponent<Renderer>().material.color = new Color(0, 1, 0);
        line8.GetComponent<Renderer>().material.color = new Color(0, 1, 0);
        yield return new WaitForSeconds(.5f);
        line5.GetComponent<Renderer>().material.color = new Color(255, 255, 255);
        line8.GetComponent<Renderer>().material.color = new Color(255, 255, 255);
        line6.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
        found1.enabled = true;
        box1.GetComponent<Renderer>().enabled = true;
        yield return new WaitForSeconds(.5f);
        line6.GetComponent<Renderer>().material.color = new Color(255, 255, 255);
        mdrop.enabled = true;
        box3.GetComponent<Renderer>().enabled = true;
    }
}
