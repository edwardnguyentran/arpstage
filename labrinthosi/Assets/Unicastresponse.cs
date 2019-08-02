using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Unicastresponse : MonoBehaviour
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

    public void onUniButtonClicked()
    {   
        text1.GetComponent<TextMeshProUGUI>();
        errortext.GetComponent<TextMeshProUGUI>();
        errortext.enabled = false;

        if (text1.text == "Please select communication type.") {
            text1.SetText("Reply received. Click inspect button to see contents.");
        }
        else
        {
            errortext.enabled = true;
        }
    }
}
