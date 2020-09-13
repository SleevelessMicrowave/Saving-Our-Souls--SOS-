using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Stats : MonoBehaviour
{
    public GameObject endScreen;
    public GameObject health;

    public float time;


    // Start is called before the first frame update
    void Start()
    {
        time = Mathf.Round(GM.time * 10) * .1f;
    }

    // Update is called once per frame
    void Update()
    {
        endScreen.GetComponent<Text>().text = "" + time;
        health.GetComponent<Text>().text = "" + 100;
    }
}
