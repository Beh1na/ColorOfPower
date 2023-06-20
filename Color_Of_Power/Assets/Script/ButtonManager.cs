using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonManager : MonoBehaviour
{
    [SerializeField] private GameObject StopPopup;


    public void ClickStopBtn()
    {
        StopPopup.SetActive(true);
    }

    public void ClickPlayAgain()
    {
        SceneManager.LoadScene(1);
    }
    public void ClickHome()
    {
        SceneManager.LoadScene(0);
    }


}
