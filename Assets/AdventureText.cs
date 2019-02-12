using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureText : MonoBehaviour
{

    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    State state;

    // Use this for initialization
    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
    }


    // Update is called once per frame
    void Update()
    {
        // ManageStates();
        
    }

    public void answerOne()
    {
        var nextStates = state.GetNextState();
        state = nextStates[0];
        textComponent.text = state.GetStateStory();
        Debug.Log("Answer One Pressed");

    }

    public void answerTwo()
    {
        var nextStates = state.GetNextState();
        state = nextStates[1];
        textComponent.text = state.GetStateStory();
        Debug.Log("Answer Two Pressed");
    }
    private void ManageStates()
    {
        /*var nextStates = state.GetNextState();
        for (int i = 0; i < nextStates.Length; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                state = nextStates[i];
            }
        }*/


        textComponent.text = state.GetStateStory();
    }
}
