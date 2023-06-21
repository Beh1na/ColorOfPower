using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager _instance;

    [SerializeField] private int p1score;
    [SerializeField] private int p2score;
    [SerializeField] private TextMeshProUGUI P1Score;
    [SerializeField] private TextMeshProUGUI P2Score;
    [SerializeField] private TextMeshProUGUI P1Scoreend;
    [SerializeField] private TextMeshProUGUI P2Scoreend;
    [SerializeField] private TextMeshProUGUI scorefinish;
    [SerializeField] private TextMeshProUGUI P1NameText;
    [SerializeField] private TextMeshProUGUI P2NameText;


    [SerializeField] private int Round;
    [SerializeField] private GameObject FinishGame;
    [SerializeField] private TextMeshProUGUI FinishText;
    private int numberfight;


    [SerializeField] private AudioClip RockAudio;
    [SerializeField] private AudioClip RepairAudio;
    public Card P1;
    public Card P2;

    private void Awake()
    {
        _instance = this;
    }

    public void SetCardP1(Card card)
    {
        P1 = card;
    }
    public Card GetCardP1()
    {
        return P1;
    }
    public void SetCardP2(Card card)
    {
        P2 = card;
    }
    public Card GetCardP2()
    {
        return P2;
    }
    public void Fight()
    {
        StartCoroutine(Fight_num());
    }
    IEnumerator Fight_num()
    {
        numberfight++;
        if (P1.Score > P2.Score)
        {

            P2.PlayWinAnimation();
            P1.PlayLoseAnimation();
            yield return new WaitForSeconds(2f);

            p1score += P1.Score - P2.Score;
            P1Score.text = p1score.ToString();

            P1.destroyitself();
            P2.destroyitself();


            //Animation Lose Card

        }
        else if (P1.Score < P2.Score)
        {

            P1.PlayWinAnimation();
            P2.PlayLoseAnimation();
            yield return new WaitForSeconds(2f);
            //Animation Lose Card
            p2score += P2.Score - P1.Score;
            P2Score.text = p2score.ToString();

            P1.destroyitself();
            P2.destroyitself();
        }
        else
        {
            P2.PlayLoseAnimation();
            P1.PlayLoseAnimation();
            yield return new WaitForSeconds(2f);
            P1.destroyitself();
            P2.destroyitself();
        }
        if (numberfight == Round * 4)
        {
            Finish();
        }
    }

    public void RockItem(bool IsP1)
    {
        GetComponent<AudioSource>().PlayOneShot(RockAudio);
        if (IsP1)
        {
            p1score -= 10;
            P1Score.text = p1score.ToString();
        }
        else
        {
            p2score -= 10;
            P2Score.text = p2score.ToString();
        }
    }
    public void RepairItem(bool IsP1)
    {
        GetComponent<AudioSource>().PlayOneShot(RepairAudio);
        if (IsP1)
        {
            p2score += 10;
            P2Score.text = p2score.ToString();

        }
        else
        {

            p1score += 10;
            P1Score.text = p1score.ToString();
        }
    }


    public int getPointP1()
    {
        return p1score;
    }
    public int getPointP2()
    {
        return p2score;
    }
    public void Finish()
    {
        if (p1score > p2score) FinishText.text = P2NameText.text;
        else FinishText.text = P1NameText.text;

        FinishGame.SetActive(true);

        P1Scoreend.text = p1score.ToString();
        P2Scoreend.text = p2score.ToString();
    }
}
