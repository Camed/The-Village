using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using UnityEditor;
using UnityEngine;

class WaterPlay
{
    System.Random r = new System.Random();
    Timer t = new Timer(1000);
    private int score = 0;
    public WaterPlay()
    {
        t.Enabled = true;
    }

    void Work()
    {
        KeyCode kc = GetArrowCode();
        //set picture to current arrow picture
        switch(kc)
        {
            case KeyCode.LeftArrow:
                if (Input.GetKey(KeyCode.LeftArrow)) score++;
                break;
            case KeyCode.DownArrow:
                if (Input.GetKey(KeyCode.DownArrow)) score++;
                break;
            case KeyCode.UpArrow:
                if (Input.GetKey(KeyCode.UpArrow)) score++;
                break;
            case KeyCode.RightArrow:
                if (Input.GetKey(KeyCode.RightArrow)) score++;
                break;
        }
    }


    private KeyCode GetArrowCode()
    {
        int x = r.Next(0, 4);

        if (x == 0) return KeyCode.LeftArrow;
        if (x == 1) return KeyCode.DownArrow;
        if (x == 2) return KeyCode.UpArrow;
        else return KeyCode.RightArrow;
    }


}

