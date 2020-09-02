using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestionManager : MonoBehaviour
{
    public TextMeshProUGUI Questions;
    public int newQuestion = 1;
    public string questionChange;
    public int QuestionSeed;

    void Start()
    {
        QuestionSeed = Random.Range(1,6)
    }
    
    
    public void Update()
    {
        public TextMeshProUGUI Questions;

        Questions.text = questionChange;

        if(QuestionSeed == 1)
        {
            if (newQuestion == 1) questionChange = "What does Ikebana mean?";

            if (newQuestion == 2) questionChange = "No";
        }
    }       

    public void OnClickRight()
    {
        newQuestion += 1;
    }

}
