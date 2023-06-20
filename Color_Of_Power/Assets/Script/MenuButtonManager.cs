using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuButtonManager : MonoBehaviour
{
    [SerializeField] GameObject BookPupop;
    [SerializeField] GameObject InfoPupop;
    public void ClickStartBtn()
    {
        SceneManager.LoadScene(1);
    }
    public void ClickinfoBtn()
    {
        InfoPupop.SetActive(true);
    }
    public void ClickbookBtn()
    {
        BookPupop.SetActive(true);

    }

    public void ClickExitPupop()
    {
        InfoPupop.SetActive(false);
        BookPupop.SetActive(false);
    }
    public void ClickexitBtn()
    {
        Application.Quit();
    }

}
