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
        if (username.Length > 2)
        {
            SceneManager.LoadScene(2);
        }
    }
}




