using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kilof : MonoBehaviour {
    private Animator anim;
    public bool gora;

	// Use this for initialization
	void Start () {
        anim = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        anim.SetBool("Gora", true);
        if (Input.GetButtonDown("Jump"))
        {
            anim.SetBool("Gora", false);
        }
    }
}
