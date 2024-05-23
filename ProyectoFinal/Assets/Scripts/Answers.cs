using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Answers : MonoBehaviour
{
    public bool correct;
    public QuizManager quizManager;

    public Color startColor;

    public void Start() {
        startColor = GetComponent<Image>().color;
    }
    public void Answer(){
        if(correct){
            GetComponent<Image>().color = Color.green;
            Debug.Log("Correct answer");
            quizManager.correct();
        }
        else{
            GetComponent<Image>().color = Color.red;
            Debug.Log("Incorrect answer");
            quizManager.incorrect();
        }
    }
}
