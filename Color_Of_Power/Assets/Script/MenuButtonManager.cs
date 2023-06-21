using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuButtonManager : MonoBehaviour
{
    [SerializeField] GameObject BookPupop;
    [SerializeField] GameObject InfoPupop;
    [SerializeField] GameObject ExitPupop;

    [SerializeField] GameObject AudioOn;
    [SerializeField] GameObject AudioOff;


    AudioSource Audio;


    private void Start()
    {
        Audio = FindObjectOfType<AudioSource>();
        Debug.Log(Audio.volume);
    }

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
    public void ClickExitBtn()
    {
        ExitPupop.SetActive(true);
    }


    public void ClickExitPupop()
    {
        InfoPupop.SetActive(false);
        BookPupop.SetActive(false);
        ExitPupop.SetActive(false);
    }
    public void Quit()
    {
        Application.Quit();
    }

    public void PlayOrPuase()
    {
        if(Audio.volume == 1)
        {
            AudioOn.SetActive(false);
            AudioOff.SetActive(true);
            Audio.volume = 0;
        }
        else
        {
            AudioOn.SetActive(true);
            AudioOff.SetActive(false);
            Audio.volume = 1;
        }
    }

}
