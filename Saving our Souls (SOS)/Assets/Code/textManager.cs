﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class textManager : MonoBehaviour
{
   
        public TMP_Text text;
        public Button firstOp;
        public Button secondOp;


        public bool option1;
        public bool option2;

        public static bool isTrue;


        private enum States
        {
        question, trueState, falseState
        };
    
        private States myState;

        void Start()
        {
        myState = States.question;
        firstOp.gameObject.SetActive(false);
        secondOp.gameObject.SetActive(false);
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
        firstOp.gameObject.SetActive(true);
        secondOp.gameObject.SetActive(true);

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
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //isTrue = true;
        DestroyMe();
    }

        void FalseState()
        {
        text.text = "";
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //isTrue = false;
        DestroyMe();
    }

        public static bool Value
        {
        get { return isTrue; }
        }
        
        void DestroyMe()
        {
        Destroy(gameObject);
        
        }

 
}
    
    



