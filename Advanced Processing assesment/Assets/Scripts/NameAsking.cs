using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class NameAsking : MonoBehaviour
{
    public TMP_InputField nameImport;
    public string username;

    public void Name()
    {
        username = nameImport.text;
    }

    public void onClick()
    {
        username = nameImport.text;
        if (username.Length >= 3 && username.Length <= 20)
        {
            SceneManager.LoadScene(2);
        }
        
    }
}




