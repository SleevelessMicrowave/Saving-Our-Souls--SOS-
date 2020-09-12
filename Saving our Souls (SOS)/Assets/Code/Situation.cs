using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Situation : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text text;
    public Button firstOp;
    public Button secondOp;


    public bool option1;
    public bool option2;

    public enum States
    {
        question, trueState, falseState
    };

    public States myState;

    void Start()
    {
        Invoke(nameof(Scenario1), 9);
    }

    public void Scenario1()
    {
        First();
        Update();
        OnEnable();

        void First()
        {
            myState = States.question;
        }

        void Update()
        {
            if (myState == States.question)
            {
                Question();
            }
            else if (myState == States.trueState)
            {
                TrueState();
            }
            else if (myState == States.falseState)
            {
                FalseState();
            }
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

        void Question()
        {
            text.text = "Look for wallet or Don’t look for wallet?";

            if (option1 == true)
            {
                myState = States.trueState;
            }
            else if (option2 == true)
            {
                myState = States.falseState;
            }
        }


        void TrueState()
        {
            text.text = "30 Time Reduction";
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        void FalseState()
        {
            text.text = "";
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }





}
