using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(textManager.Value == true)
        {
            anim.SetBool("isLooking", true);
        }
        else
        {
            anim.SetBool("isLooking", false);
        }
    }
}
