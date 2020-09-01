using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestionManager : MonoBehaviour
{
    public TextMeshProUGUI Questions;
    public int newQuestion = 1;
    public string questionChange;


    public void Update()
    {
        Questions.text = questionChange;

        if (newQuestion == 1) questionChange = "What does Ikebana mean?";

        if (newQuestion == 2) questionChange = "No";
    }

    public void QuestionAsk()
    {
        Questions.text = questionChange;
        if (newQuestion == 1) questionChange = "Yes"; 
            
    }

    public void OnClick()
    {
        newQuestion += 1;
    }

}
