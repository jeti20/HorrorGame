using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainManuFunction : MonoBehaviour
{
    [SerializeField] private ConfirmationWindow confirmationWindow;

    public GameObject fadeOut;
    public GameObject loadText;
    public AudioSource buttonClick;

    public GameObject loadButton;
    public int loadInt;

    void Start()
    {
        loadInt = PlayerPrefs.GetInt("AutoSave");
        if (loadInt > 0)
        {
            loadButton.SetActive(true);

        }
    }

    public void NewGameButton()
    {
        StartCoroutine(NewGameStart());
    }

    IEnumerator NewGameStart()
    {
        fadeOut.SetActive(true);
        buttonClick.Play();
        yield return new WaitForSeconds(0.5f);
        loadText.SetActive(true);
        yield return new WaitForSeconds(3);
        
        SceneManager.LoadScene(4);

    }


    //odtwarzanie zapisów 
    public void LoadGameButton()
    {
        StartCoroutine(LoadGameStart());
    }

    IEnumerator LoadGameStart()
    {
        fadeOut.SetActive(true);
        buttonClick.Play();
        yield return new WaitForSeconds(3);
        loadText.SetActive(true);
        SceneManager.LoadScene(loadInt);
        Debug.Log(loadInt);
    }

    public void LoadSite()
    {
        Application.OpenURL("https://github.com/jeti20");
    }

    public void Credits()
    {
        SceneManager.LoadScene(6);
        
    }

    //Exit button
    public void Exit()
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
