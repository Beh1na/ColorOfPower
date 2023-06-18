using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject DrawBtn;
    [SerializeField] private GameObject ChangeBtn;
    [SerializeField] private GameObject FightBtn;

    [SerializeField] private int numberfight;
    [SerializeField] private bool IsSetcards;

    private void Start()
    {
        numberfight = 0;
        DrawBtnActive();
    }

    public void DrawButtonClick()
    {
        ChangeBtnActive();
    }
    public void ChangeButtonClick()
    {
        if(ScoreManager._instance.GetCardP1() != null && ScoreManager._instance.GetCardP2() != null)
        {
            IsSetcards = true;
        }

        if (IsSetcards)
        {
            FightBtnActive();
            IsSetcards = false;
        }
    }
    public void FightButtonClick()
    {
        numberfight++;
        if (numberfight == 5)
        {
            DrawBtnActive();
            numberfight = 0;
        }
        else
        {
            ChangeBtnActive();
        }

    }

    private void ChangeBtnActive()
    {
        DrawBtn.SetActive(false);
        ChangeBtn.SetActive(true);
        FightBtn.SetActive(false);
    }
    private void FightBtnActive()
    {
        DrawBtn.SetActive(false);
        ChangeBtn.SetActive(false);
        FightBtn.SetActive(true);
    }

    private void DrawBtnActive()
    {
        DrawBtn.SetActive(true);
        ChangeBtn.SetActive(false);
        FightBtn.SetActive(false);
    }

}
