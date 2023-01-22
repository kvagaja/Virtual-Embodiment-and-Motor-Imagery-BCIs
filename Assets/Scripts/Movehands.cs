using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movehands : MonoBehaviour {
    public Animator anim;
    
    // Start is called before the first frame update
    void Start() {
        anim = GetComponent<Animator>();        
    }

    // Update is called once per frame
    void Update() {
        if(Input.GetKeyDown("d")) 
        {
            anim.Play("RH_close");
        }     
        if(Input.GetKeyDown("a")) 
        {
            anim.Play("LH_close");
        }
        if(Input.GetKeyDown("w")) 
        {
            anim.Play("Sitting_open");
        }
    }
}
