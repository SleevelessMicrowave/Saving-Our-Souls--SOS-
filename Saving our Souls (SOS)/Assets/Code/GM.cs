using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GM : MonoBehaviour
{
    public TMP_Text text;
    public Button firstOp;
    public Button secondOp;
    public TMP_Text text1;
    public TMP_Text text2;
    public Canvas can;

    public bool option1;
    public bool option2;

    public bool start;
    public bool check1;
    public bool check2;

    private Animator anim;

    public GameObject walletButton;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("FirstPersonPlayer").GetComponent<PlayerMovement>().enabled = false;
        GameObject.Find("Main Camera").GetComponent<MouseLook>().enabled = false;
        can.gameObject.SetActive(false);
        check1 = false;
        start = true;
        anim = GetComponent<Animator>();

        if (start == true)
        {
            StartCoroutine(S1());
        }
        
        if (check1 == true)
        {
            Debug.Log("Am i here?");
            anim.SetBool("isLooking", true);
            Debug.Log("here?");
            StartCoroutine(S2());
        }


        //GameObject.Find("Game Master").GetComponent<Animation>().Play("Wake Up Animation");
    }

    // Update is called once per frame
    void Update()
    {
        /*if (start == true)
        {
            StartCoroutine(S1());
        }
        
        if (check1 == true)
        {
            Debug.Log("Am i here?");
            anim.SetBool("isLooking", true);
            Debug.Log("here?");
            StartCoroutine(S2());
        }*/
        
        
        
    }

    public IEnumerator S1()
    {
        yield return new WaitForSeconds(9f);

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        can.gameObject.SetActive(true);
        Question1();

        if (option1 == true)
        {
            Debug.Log("here");
            
            can.gameObject.SetActive(false);
            check1 = true;
            start = false;
               

        }
        else if (option2 == true)
        {
            can.gameObject.SetActive(false);
            start = false;
        }



    }

    public IEnumerator S2()
    {
        yield return new WaitForSeconds(6f);
        check1 = false;
        Debug.Log("do i make it here");

        can.gameObject.SetActive(true);

        Debug.Log("whatbouthere");

        Question2();

        if (option1 == true)
        {

            can.gameObject.SetActive(false);
            //GameObject.Find("FirstPersonPlayer").GetComponent<Animator>().Play("Go to Bedroom Door");
            //StartCoroutine(S2());
        }
        else if (option2 == true)
        {
            can.gameObject.SetActive(false);
        }

    }

    void Question1()
    {
        ChangeColor1();
        ChangeColor2();
        text.text = "Look for wallet or Don’t look for wallet?";
        text1.text = "Look for wallet";
        text2.text = "Don't look for wallet";

    }

    void Question2()
    {
        ChangeColor1();
        ChangeColor2();
        text.text = "Go to bedroom door or go to window?";
        text1.text = "Go to bedroom door";
        text2.text = "Go to window";
    }


    void ChangeColor1()
    {
        ColorBlock colors = firstOp.colors;
        colors.normalColor = new Color32(231, 0, 0, 255);
        firstOp.colors = colors;
    }
    void ChangeColor2()
    {
        ColorBlock colors = secondOp.colors;
        colors.normalColor = new Color32(231, 0, 0, 255);
        secondOp.colors = colors;
    }

    void OnEnable()
    {
        firstOp.onClick.AddListener(delegate
        {
            option1 = true;
        });

        secondOp.onClick.AddListener(delegate
        {
            option2 = true;
        });
    }

    public void LookForWallet()
    {
        walletButton.SetActive(true);

        Debug.Log("works");
    }


}
