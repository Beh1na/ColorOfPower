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
    // Start is called before the first frame update
    void Start()
    {
        StoryText.text = "";
        StartCoroutine(TypeSentence(StoryPt1, ButtonContinue));
    }

    IEnumerator TypeSentence (string sentence , GameObject Button)
    {
        StoryText.text = "";
        foreach(char Letter in sentence.ToCharArray())
        {
            StoryText.text += Letter;
            yield return null;
        }
        GetComponent<AudioSource>().volume = 0;
        Button.SetActive(true);
    }

    public void ClickNextPart()
    {
        ButtonContinue.SetActive(false);
        GetComponent<AudioSource>().volume = 1;
        StoryText.text = "";
        StartCoroutine(TypeSentence(StoryPt2, StartGame));

    }
    public void ClickRunGame()
    {
        SceneManager.LoadScene(2);
    }
}
