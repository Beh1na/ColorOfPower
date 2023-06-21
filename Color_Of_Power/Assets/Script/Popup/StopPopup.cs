using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class StopPopup : MonoBehaviour
{
    [SerializeField] private Slider ValumeSlider;
    [SerializeField] private AudioSource GameAudio;

    public void VolumeSlider(float volume)
    {
        GameAudio.volume = volume;
    }
    void Start()
    {
        ValumeSlider.value = 1f;
        GameAudio.volume = ValumeSlider.value;
        Time.timeScale = 0f;
    }
    private void Update()
    {
        GameAudio.volume = ValumeSlider.value;
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
