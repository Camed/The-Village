using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse : MonoBehaviour
{
    public int poziom;

    void OnMouseOver()
     {

        // print(gameObject.name);
        if (Input.GetMouseButtonDown(0))
        {
            Application.LoadLevel(poziom);
        }
            
    }
}
