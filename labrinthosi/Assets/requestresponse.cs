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
        }
        else
        {
            errortext.enabled = true;
        }
    }
}
