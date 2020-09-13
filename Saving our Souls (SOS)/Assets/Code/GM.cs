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

    private static bool done;

    public bool start;
    public bool check1;
    public bool check2;

    public Animator anim;

    public GameObject button1;
    public GameObject button2;

    private static int animationCounter = 0;
    private static float pathCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("FirstPersonPlayer").GetComponent<PlayerMovement>().enabled = false;
        GameObject.Find("Main Camera").GetComponent<MouseLook>().enabled = false;
        can.gameObject.SetActive(false);
        check1 = false;
        start = true;
        anim = GetComponent<Animator>();
        done = false;

        /*if (start == true)
        {
            StartCoroutine(S1());
        }

        if (done == true)
        {
            StartCoroutine(S2());
        }
        
        if (check1 == true)
        {
            Debug.Log("Am i here?");
            anim.SetBool("isLooking", true);
            Debug.Log("here?");
            StartCoroutine(S2());
        }*/


        //GameObject.Find("Game Master").GetComponent<Animation>().Play("Wake Up Animation");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (start == true)
        {
            start = false;
            Debug.Log(start);
            pathCounter += .25f;
            StartCoroutine(S1());
            Debug.Log("Dont repeat");
        }

        //Debug.Log(pathCounter);

        if (pathCounter == 1)
        {
            pathCounter+=.5f;
            animationCounter++;
            Debug.Log("What");
            StartCoroutine(S2());
            Debug.Log("number 2");
        }

        if (pathCounter == 2)
        {
            pathCounter+=.5f;
            animationCounter++;
            StartCoroutine(S3());
        }

        if (pathCounter == 3)
        {
            pathCounter += .5f;
            animationCounter++;
            StartCoroutine(S4());
        }

        /*if (check1 == true)
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

        /*if (option1 == true)
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
        }*/



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

    public IEnumerator S3()
    {
        yield return new WaitForSeconds(6);
        Debug.Log("s3");
        can.gameObject.SetActive(true);
        Question3();
    }

    public IEnumerator S4()
    {
        yield return new WaitForSeconds(5);
        Debug.Log("s4");
        can.gameObject.SetActive(true);
        Question4();
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
        text2.text = "Jump out the window";
    }

    void Question3()
    {
        ChangeColor1();
        ChangeColor2();
        text.text = "Open the door or touch the door with back of hand?";
        text1.text = "Open the door";
        text2.text = "Touch the door with back of hand";
    }

    void Question4()
    {
        ChangeColor1();
        ChangeColor2();
        text.text = "You're on fire!";
        text1.text = "Stop, drop, and roll!";
        text2.text = "Keep going";
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



   /* void OnEnable()
    {
        firstOp.onClick.AddListener(delegate
        {
            option1 = true;
        });

        secondOp.onClick.AddListener(delegate
        {
            option2 = true;
        });
    }*/

    public void ButtonOne()
    {
        button1.SetActive(true);
        Debug.Log("Animation counter: "  + animationCounter);
        done = true;
        pathCounter += .5f;
        if (animationCounter == 0)
        {
            anim.SetBool("isLooking", true);

        }
        else if (animationCounter == 1)
        {
            anim.SetBool("leftButt", true);
        }
        else if (animationCounter ==2)
        {
            anim.SetBool("slapDoor", true);
        }
        else if (animationCounter == 3)
        {
            anim.SetBool("roll", true);
        }
        start = false;
        can.gameObject.SetActive(false);
        Debug.Log("button press");
    }

    public void ButtonTwo()
    {
        button2.SetActive(true);
        Debug.Log("button2");
        Debug.Log("Animation counter: " + animationCounter);
        pathCounter += .5f;
        if (animationCounter == 0)
        {
            animationCounter++;

            can.gameObject.SetActive(true);

            Question2();
        }
        else if (animationCounter == 1)
        {
            animationCounter++;
            anim.SetBool("rightButt", true);
        }
        else if (animationCounter ==2)
        {
            animationCounter++;
            anim.SetBool("backHandDoor", true);
        }
    }


}
