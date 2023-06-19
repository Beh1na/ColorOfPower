using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] private GameObject ChooseSide;
    [SerializeField] private GameObject StopPopup;
    [SerializeField] private GameObject BookPopup;

    public void ClickAlienBtn()
    {
        ChooseSide.SetActive(false);
    }
    public void ClickTerrestrialBtn()
    {
        ChooseSide.SetActive(false);
    }

    public void ClickStopBtn()
    {
        StopPopup.SetActive(true);
    }
    public void ClickBookBtn()
    {
        BookPopup.SetActive(true);
    }


}
