using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class ButtonManager : MonoBehaviour
{
    [SerializeField] private GameObject StopPopup;
    [SerializeField] private GameObject IntroPopup;
    [SerializeField] private TMP_InputField Player1;
    [SerializeField] private TMP_InputField Player2;

    [SerializeField] private TextMeshProUGUI Player1Text;
    [SerializeField] private TextMeshProUGUI Player2Text;
    [SerializeField] private TextMeshProUGUI Player1Textend;
    [SerializeField] private TextMeshProUGUI Player2Textend;
    [SerializeField] private TextMeshProUGUI Player1Score;
    [SerializeField] private TextMeshProUGUI Player2Score;

    private void Start()
    {
        Time.timeScale = 0f;

    }

    public void ClickOk()
    {
        Player1Text.text = Player1.text;
        Player1Textend.text = Player1.text;
        Player2Text.text = Player2.text;
        Player2Textend.text = Player2.text;

        Player1Score.text = "0";
        Player2Score.text = "0";
        IntroPopup.SetActive(false);
        Time.timeScale = 1f;
    }

    public void ClickStopBtn()
    {
        StopPopup.SetActive(true);
    }

    public void ClickPlayAgain()
    {
        SceneManager.LoadScene(2);
    }
    public void ClickHome()
    {
        SceneManager.LoadScene(0);
    }


}
