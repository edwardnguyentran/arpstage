using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Inspectresponse : MonoBehaviour
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

    public void onInspectButtonClicked()
    {   
        text1.GetComponent<TextMeshProUGUI>();
        errortext.GetComponent<TextMeshProUGUI>();
        errortext.enabled = false;

        if (text1.text == "Reply received. Click inspect button to see contents.")
        {
            text1.SetText("Here are the details of the reply." + System.Environment.NewLine + "Source IP: X" + System.Environment.NewLine + "Source MAC address: X");
            errortext.SetText("Error: This is not in line with protocol.");
        }
        else if (text1.text == "Reply discarded. New reply received. Click inspect button to see contents.")
        {
            text1.SetText("Here are the details of the reply." + System.Environment.NewLine + "Source IP: Y" + System.Environment.NewLine + "Source MAC address: Y");
        }
        else
        {
            errortext.enabled = true;
        }
    }
}
