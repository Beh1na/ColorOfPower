using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class StopPopup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;
    }

    public void ClickResumeBtn()
    {
        Time.timeScale = 1f;
        gameObject.SetActive(false);
    }
    public void ClickMainMenuBtn()
    {
        SceneManager.LoadScene(0);
    }

}
