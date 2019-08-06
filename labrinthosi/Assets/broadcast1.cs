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
    public GameObject line1;
    public GameObject line2;
    public GameObject line3;
    public GameObject line4;
    public GameObject line5;
    public GameObject line6;
    public GameObject line7;
    public GameObject line8;


    // Start is called before the first frame update
    void Start()
    {
        title1.enabled = false;
        title2.enabled = false;
        title3.enabled = false;
        title4.enabled = false;
        found1.enabled = false;
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
        found1.GetComponent<TextMeshProUGUI>();
        line1.GetComponent<GameObject>();
        line2.GetComponent<GameObject>();
        line3.GetComponent<GameObject>();
        line4.GetComponent<GameObject>();
        line5.GetComponent<GameObject>();
        line6.GetComponent<GameObject>();
        line7.GetComponent<GameObject>();
        line8.GetComponent<GameObject>();
    }

    public void broadcastClick()
    {
        errortext.GetComponent<TextMeshProUGUI>();
        title1.GetComponent<TextMeshProUGUI>();
        title2.GetComponent<TextMeshProUGUI>();
        title3.GetComponent<TextMeshProUGUI>();
        title4.GetComponent<TextMeshProUGUI>();
        found1.GetComponent<TextMeshProUGUI>();
        line1.GetComponent<GameObject>();
        line2.GetComponent<GameObject>();
        line3.GetComponent<GameObject>();
        line4.GetComponent<GameObject>();
        line5.GetComponent<GameObject>();
        line6.GetComponent<GameObject>();
        line7.GetComponent<GameObject>();
        line8.GetComponent<GameObject>();


        if (title1.enabled == false && title2.enabled == false && title3.enabled == false && title4.enabled == false)
        {
            title1.enabled = true;
            errortext.enabled = false;
            line1.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
            changeColour();
            found1.enabled = true;
        }
        else
        {
            errortext.enabled = true;
        }
    }

    IEnumerator changeColour()
    {
        line1.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
        yield return new WaitForSeconds(3);
        line1.GetComponent<Renderer>().material.color = new Color(0, 0, 0);
        yield return new WaitForSeconds(3);
        line1.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
    }
}
