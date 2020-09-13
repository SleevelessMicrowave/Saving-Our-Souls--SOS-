using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class FloodGM : MonoBehaviour
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
    //public bool check1;
    //public bool check2;

    public Animator anim;

    public GameObject button1;
    public GameObject button2;



    private static int animationCounter = 0;
    private static float pathCounter = 0;

    public static float time = 0;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("FirstPersonPlayer2").GetComponent<PlayerMovement>().enabled = false;
        GameObject.Find("Main Camera").GetComponent<MouseLook>().enabled = false;
        can.gameObject.SetActive(false);
        //check1 = false;
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
        time += Time.deltaTime;

        if (start == true)
        {
            start = false;
            Debug.Log(start);
            pathCounter += .5f;
            StartCoroutine(S1());
            Debug.Log("Dont repeat");
        }

        //Debug.Log(pathCounter);

        if (pathCounter == 1)
        {
            pathCounter += .5f;
            animationCounter++;
            Debug.Log("What");
            StartCoroutine(S2());
            Debug.Log("number 2");
        }

        if (pathCounter == 2)
        {

            pathCounter += .5f;
            animationCounter++;
            StartCoroutine(S3());
        }

        if (pathCounter == 3)
        {
            pathCounter += .5f;
            animationCounter++;
            StartCoroutine(S4());
        }

        if (pathCounter == 4)
        {
            pathCounter += .5f;
            animationCounter++;
            StartCoroutine(S5());
        }

        if (pathCounter == 5)
        {
            pathCounter += .5f;
            animationCounter++;
            StartCoroutine(S6());
        }

        if (pathCounter == 6)
        {
            pathCounter += .5f;
            animationCounter++;
            StartCoroutine(S7());
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
        //check1 = false;
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
        //SceneManager.LoadScene("EndScreen");
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

    public IEnumerator S5()
    {
        yield return new WaitForSeconds(4);
        Debug.Log("s5");
        can.gameObject.SetActive(true);
        Question5();
    }

    public IEnumerator S6()
    {
        yield return new WaitForSeconds(5);
        Debug.Log("s6");
        can.gameObject.SetActive(true);
        //Question6();
    }

    public IEnumerator S7()
    {
        yield return new WaitForSeconds(5);
        Debug.Log("s7");
        SceneManager.LoadScene("EndScreen");
    }

    void Question1()
    {
        ChangeColor1();
        ChangeColor2();
        text.text = "Turn on the headlights!";
        text1.text = "urn on the headlight";
        text2.text = "Turn on the headlight";

    }

    void Question2()
    {
        ChangeColor1();
        ChangeColor2();
        text.text = "Open the car door!";
        text1.text = "Open the car door";
        text2.text = "Open the car door";
    }

    void Question3()
    {
        ChangeColor1();
        ChangeColor2();
        text.text = "Keep trying to open door or smash window";
        text1.text = "keep trying";
        text2.text = "Smash window";
    }

    void Question4()
    {
        ChangeColor1();
        ChangeColor2();
        text.text = "Get out of the car";
        text1.text = "Get out of the car";
        text2.text = "Get out of the car";
    }

    void Question5()
    {
        ChangeColor1();
        ChangeColor2();
        text.text = "Get to high ground!";
        text1.text = "Get to high ground";
        text2.text = "Get to high ground";
    }

    /*void Question6()
    {
        ChangeColor1();
        ChangeColor2();
        text.text = "You forgot your cat!";
        text1.text = "Get the cat!";
        text2.text = "Wait for the fire department.";
    }*/


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
        Debug.Log("Animation counter: " + animationCounter);
        done = true;
        pathCounter += .5f;
        if (animationCounter == 0)
        {
            anim.SetBool("light", true);

        }
        else if (animationCounter == 1)
        {
            anim.SetBool("openDoor", true);
        }
        else if (animationCounter == 2)
        {
            anim.SetBool("neckWater", true);
        }
        else if (animationCounter == 3)
        {
            anim.SetBool("outtaCar", true);
        }
        else if (animationCounter == 4)
        {
            anim.SetBool("hiGround", true);
            //SceneManager.LoadScene("Congratulations");
        }
        else if (animationCounter == 5)
        {
            anim.SetBool("forgotCat", true);
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


            anim.SetBool("light", true);
        }
        else if (animationCounter == 1)
        {

            anim.SetBool("openDoor", true);
        }
        else if (animationCounter == 2)
        {
            anim.SetBool("smash", true);

        }
        else if (animationCounter == 3)
        {

            anim.SetBool("outtaCar", true);
        }
        else if (animationCounter == 4)
        {
            anim.SetBool("hiGround", true);

        }
        
        can.gameObject.SetActive(false);
    }


}
