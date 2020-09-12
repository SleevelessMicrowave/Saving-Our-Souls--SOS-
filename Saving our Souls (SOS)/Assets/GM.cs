using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("FirstPersonPlayer").GetComponent<PlayerMovement>().enabled = false;
        GameObject.Find("Main Camera").GetComponent<MouseLook>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
