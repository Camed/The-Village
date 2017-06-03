using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.UI;
public class ArrowChange : MonoBehaviour
{

    public Sprite ArrowUp, ArrowDown, ArrowLeft, ArrowRight;
    public Image ArrowsUI;
    public int kc = 0;

    System.Random r = new System.Random();
    Timer t = new Timer(1000);
    private int score = 0;

    private int GetArrowCode()
    {
            return r.Next(0, 4);

            //if (x == 0) return KeyCode.UpArrow;
            //if (x == 1) return KeyCode.DownArrow;
            //if (x == 2) return KeyCode.LeftArrow;
            //else return KeyCode.RightArrow;
    }

    void Work(object o, ElapsedEventArgs e)
    {
        kc = GetArrowCode();
    }
    void Start ()
    {
        kc = GetArrowCode();

        ArrowUp = Resources.Load("arrow_0", typeof(Sprite)) as Sprite;
        ArrowDown = Resources.Load("arrow_1", typeof(Sprite)) as Sprite;
        ArrowLeft = Resources.Load("arrow_2", typeof(Sprite)) as Sprite;
        ArrowRight = Resources.Load("arrow_3", typeof(Sprite)) as Sprite;
        t.Enabled = true;
        t.Elapsed += new ElapsedEventHandler(Work);
        t.Start();

    }
	
	// Update is called once per frame
	void Update () {
        if (kc == 0) ArrowsUI.sprite = ArrowUp;
        else if (kc == 1) ArrowsUI.sprite = ArrowDown;
        else if (kc == 2) ArrowsUI.sprite = ArrowLeft;
        else ArrowsUI.sprite = ArrowRight;
	}
}
