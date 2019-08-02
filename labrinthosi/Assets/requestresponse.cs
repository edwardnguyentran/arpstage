using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class requestresponse : MonoBehaviour
{
    public TextMeshProUGUI text1;
    public TextMeshProUGUI errortext;
    // Start is called before the first frame update
    void Start()
    {
        text1.GetComponent<TextMeshProUGUI>();
        errortext.GetComponent<TextMeshProUGUI>();
        errortext.enabled = false;
        text1.SetText("ARP Protocol Online");
        text1.text = "ARP Protocol Online";
    }

    // Update is called once per frame
    void Update()
    {
        text1.GetComponent<TextMeshProUGUI>();
        errortext.GetComponent<TextMeshProUGUI>();

    }

    public void onReqButtonClicked()
    {   
        text1.GetComponent<TextMeshProUGUI>();
        errortext.GetComponent<TextMeshProUGUI>();
        errortext.enabled = false;

        if (text1.text == "ARP Protocol Online") {
            text1.SetText("Please select communication type.");
            text1.text = "Please select communication type";
        }
        else
        {
            errortext.enabled = true;
        }
    }
}
