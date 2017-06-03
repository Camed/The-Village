using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SettingsButton : MonoBehaviour
{
    Text txt;
    private int currentscore = 0;
    int i = 1;
    // Use this for initialization
    void Start()
    {
        txt = gameObject.GetComponent<Text>();
        txt.text = "Score : " + currentscore;
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = "Score : " + currentscore;
        currentscore += i;
    }
}

