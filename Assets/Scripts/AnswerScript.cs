using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerScript : MonoBehaviour
{
    public bool isCorrect = false;

    public QuizManager quizManager;
    public soundManagerScript soundManager;
    

    [SerializeField]
    GameObject greatImage;
   
    public void Answer()
    {
        if(isCorrect)
        {
            Debug.Log("Correct answer");
            quizManager.correct();
            greatImage.SetActive(true);
            soundManager.PlayPositiveSound();

        } else
        {
            Debug.Log("Wrong answer");
            quizManager.correct();
        }
    }
}
