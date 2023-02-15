using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movehands : MonoBehaviour {
    public Animator anim;

    public static bool RH, LH, IDLE;
    
    // Start is called before the first frame update
    void Start() {
        anim = GetComponent<Animator>();        
    }

    // Update is called once per frame
    void Update() {
        if(Input.GetKeyDown("d") || RH) 
        {
            anim.Play("RH_close");
            Debug.Log("RH");
        }     
        if(Input.GetKeyDown("a") || LH) 
        {
            anim.Play("LH_close");
            Debug.Log("LH");
        }
        if (Input.GetKeyDown("w") || IDLE) 
        {
            anim.Play("Sitting_open");
            Debug.Log("Sitting_open");
        }
    }
}
