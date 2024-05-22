using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class QuizManager : MonoBehaviour
{
    public List<QuestionAnswers> questionAnswers;
    public GameObject[] options;
    public int currentQuestion;
    public TextMeshProUGUI QuestionTxt;

    public TextMeshProUGUI ScoreTxt;
    public int totalQuestions=0;
    public int score;

    public GameObject quizPanel;
    public GameObject gameOverPanel;

    public GameObject gameWinPanel;
    public void Start(){
        totalQuestions = questionAnswers.Count;
        generateQuestion();

    }
    public void retryQuiz(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void finishQuiz(){
        SceneManager.LoadScene(2);
    }
    public void gameOver(){
        quizPanel.SetActive(false);
        if(score==totalQuestions){
            gameWinPanel.SetActive(true);
        }
        else{
            gameOverPanel.SetActive(true);
            ScoreTxt.text = score.ToString() + '/' + totalQuestions.ToString();
        }
    }
    public void correct(){
        score+=1;
        questionAnswers.RemoveAt(currentQuestion);
        StartCoroutine(waitForNext());
    }
    
    public void incorrect(){
        questionAnswers.RemoveAt(currentQuestion);
        StartCoroutine(waitForNext());
    }
    void setAnswers(){
        for (int i = 0;i<options.Length;i++){
            options[i].GetComponent<Answers>().correct = false;
            options[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = questionAnswers[currentQuestion].Answer[i];
            options[i].GetComponent<Image>().color = options[i].GetComponent<Answers>().startColor;
            if(questionAnswers[currentQuestion].CorrectAnswer == i+1){
                options[i].GetComponent<Answers>().correct = true;
            }
        }
    }

    IEnumerator waitForNext(){
        yield return new WaitForSeconds(1);
        generateQuestion();
    }
    void generateQuestion(){
        if(questionAnswers.Count > 0){
            currentQuestion = Random.Range(0,questionAnswers.Count);
            QuestionTxt.text = questionAnswers[currentQuestion].Question;
            setAnswers();
        }
        else{
            Debug.Log("Out of questions");
            gameOver();
        }
    }
}
