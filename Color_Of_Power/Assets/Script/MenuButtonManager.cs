using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuButtonManager : MonoBehaviour
{
    public void ClickStartBtn()
    {
        SceneManager.LoadScene(1);
    }
    public void ClickinfoBtn()
    {

    }
    public void ClickbookBtn()
    {


    }
    public void ClickexitBtn()
    {
        Application.Quit();
    }

}
