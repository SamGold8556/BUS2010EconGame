using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject {

  [TextArea(14,10)] [SerializeField] string storyText;
    [SerializeField] State[] nextStates;
    [SerializeField] int currentQuizScore;

    public string GetStateStory()
    {
        return storyText;
    }

    public State[] GetNextState()
    {
        return nextStates;
    }

    public int GetQjuizScore()
    {
        return currentQuizScore;
    }
}
