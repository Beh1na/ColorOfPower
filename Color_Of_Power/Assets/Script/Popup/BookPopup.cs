using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BookPopup : MonoBehaviour
{
    [SerializeField] private GameObject NextBtn;
    [SerializeField] private GameObject PreviusBtn;

    [SerializeField] private GameObject[] CardDescription;

    int currentlyNumber;
    private void Start()
    {
        PreviusBtn.SetActive(false);
        CardDescription[0].SetActive(true);
    }

    public void ClickNext()
    {
        currentlyNumber++;
        PreviusBtn.SetActive(true);
        if (currentlyNumber == 22) NextBtn.SetActive(false);
        else NextBtn.SetActive(true);
        CardDescription[currentlyNumber - 1].SetActive(false);
        CardDescription[currentlyNumber].SetActive(true);
    }
    public void ClickPrevius()
    {

        currentlyNumber--;
        NextBtn.SetActive(true);
        if (currentlyNumber == 0) PreviusBtn.SetActive(false);
        else PreviusBtn.SetActive(true);

        CardDescription[currentlyNumber + 1].SetActive(false);
        CardDescription[currentlyNumber].SetActive(true);
    }

    public void ClickResumeBtn()
    {
        Time.timeScale = 1f;
        gameObject.SetActive(false);
    }
}
