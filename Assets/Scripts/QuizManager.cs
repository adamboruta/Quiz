using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
    public List<QnA> QnA;
    public GameObject[] options;
    public int currentQuestion;

    private int qCount;

    public Text questionText;
    public string questionType;

    [SerializeField] SpriteChanger sprchng;

    public GameObject questionCount;
    public greatScript greatScript;

    [SerializeField]
    TextMeshProUGUI questionNumber;

    [SerializeField]
    GameObject adPanel;

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

    public void wrong()
    {
        adPanel.SetActive(true);
    }
    void generateQuestion()
    {
        Debug.Log(QnA.Count);
        currentQuestion = Random.Range(0, QnA.Count);
        questionText.text = QnA[currentQuestion].Question;
        setAnswer();
        qCount++;
        questionCount.GetComponent<Animator>().SetTrigger("show");
        setQuestionIcon();
        
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

    void setQuestionIcon()
    {
        questionType = QnA[currentQuestion].questionType.ToString();
        
        switch (questionType)
        {
            case "geo":
                sprchng.GetComponent<Image>().overrideSprite = sprchng.geoIcon;
                break;
            case "maths":
                sprchng.GetComponent<Image>().overrideSprite = sprchng.mathsIcon;
                break;
            case "general":
                sprchng.GetComponent<Image>().overrideSprite = sprchng.generalIcon;
                break;
            case "books":
                sprchng.GetComponent<Image>().overrideSprite = sprchng.booksIcon;
                break;
            case "bio":
                sprchng.GetComponent<Image>().overrideSprite = sprchng.bioIcon;
                break;
            case "hist":
                sprchng.GetComponent<Image>().overrideSprite = sprchng.historyIcon;
                break;
            case "phys":
                sprchng.GetComponent<Image>().overrideSprite = sprchng.physicsIcon;
                break;
        }
    }

    private void Update()
    {
        questionNumber.text = qCount.ToString();

        if(QnA.Count == 0) //wygrana
        {
            SceneManager.LoadScene("Koniec");
        }
    }
}
