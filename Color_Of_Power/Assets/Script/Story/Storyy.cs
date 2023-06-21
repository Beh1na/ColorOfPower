using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class Storyy : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI StoryText;
    [SerializeField] private string StoryPt1;
    [SerializeField] private string StoryPt2;
    [SerializeField] private GameObject ButtonContinue;
    [SerializeField] private GameObject StartGame;
    [SerializeField] private AudioClip Type;
    // Start is called before the first frame update
    void Start()
    {
        StoryText.text = "";
        StartCoroutine(TypeSentence(StoryPt1));
        GetComponent<AudioSource>().PlayOneShot(Type);
    }

    IEnumerator TypeSentence (string sentence)
    {
        StoryText.text = "";
        foreach(char Letter in sentence.ToCharArray())
        {
            StoryText.text += Letter;
            yield return new WaitForSeconds(0.05f);
        }
        GetComponent<AudioSource>().volume = 0;
    }

    public void ClickNextPart()
    {
        StoryText.text = "";
        StartCoroutine(TypeSentence(StoryPt2));
        GetComponent<AudioSource>().volume = 1; 
        ButtonContinue.SetActive(false);
        StartGame.SetActive(true);
    }
    public void ClickRunGame()
    {
        SceneManager.LoadScene(2);
    }
}
