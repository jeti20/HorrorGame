using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Windowmanagment : MonoBehaviour
{
    [SerializeField] private ConfirmationWindow confirmationWindow;
    
    void Start()
    {
        OpenConfirmationWindow("Are you sure?");
    }

    private void OpenConfirmationWindow(string message)
    {
        confirmationWindow.gameObject.SetActive(true);
        confirmationWindow.yesButton.onClick.AddListener(YesClicked);
        confirmationWindow.noButton.onClick.AddListener(NoClicked);
        confirmationWindow.messageText.text = message;

    }

    private void YesClicked()
    {
        Application.Quit();
        Debug.Log("exit");
        Debug.Log("Yes clicked");
    }

    private void NoClicked()
    {
        confirmationWindow.gameObject.SetActive(false);
        Debug.Log("No clicked");
        
    }
}
