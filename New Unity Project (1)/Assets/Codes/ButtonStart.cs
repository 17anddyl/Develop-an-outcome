using System.Collections;
using UnityEngine.UI;
using UnityEngine;


public class ButtonStart : MonoBehaviour
{
    public Button yourButton;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(Update);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("You have clicked the button");    
    }
}
