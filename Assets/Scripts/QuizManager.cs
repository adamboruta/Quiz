using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuizManager : MonoBehaviour
{
    public List<QnA> QnA;
    public GameObject[] options;
    public int currentQuestion;

    private int qCount;

    public Text questionText;

    public GameObject questionCount;
    public greatScript greatScript;

    [SerializeField]
    TextMeshProUGUI questionNumber;

    private void Start()
    {
        generateQuestion();
    }

    public void correct()
    {
        QnA.RemoveAt(currentQuestion);
        //greatScript.show(); //ROZWIAZAC
        generateQuestion();
              
    }
    void generateQuestion()
    {
        currentQuestion = Random.Range(0, QnA.Count);
        questionText.text = QnA[currentQuestion].Question;
        setAnswer();
        qCount++;
        questionCount.GetComponent<Animator>().SetTrigger("show");
    }

    void setAnswer()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];

            if (QnA[currentQuestion].CorrectAnswer == i + 1)
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;
            }
        }
    }

    private void Update()
    {
        questionNumber.text = qCount.ToString();
    }
}