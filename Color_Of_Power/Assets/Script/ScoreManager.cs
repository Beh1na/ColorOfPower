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

    [SerializeField] private int FightNumber;
    [SerializeField] private GameObject FinishGame;
    [SerializeField] private TextMeshProUGUI FinishText;
    private int numberfight;


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
        numberfight++;
        if (P1.Score > P2.Score)
        {
            //Animation Lose Card
            p1score += P1.Score - P2.Score;
            P1Score.text = p1score.ToString();

            P1.destroyitself();
            P2.destroyitself();
        }
        else if (P1.Score < P2.Score)
        {
            //Animation Lose Card
            p2score += P2.Score - P1.Score;
            P2Score.text = p2score.ToString();

            P1.destroyitself();
            P2.destroyitself();
        }
        else
        {
            //Animation Lose Card for both
            P1.destroyitself();
            P2.destroyitself();
        }
        if(numberfight == FightNumber)
        {
            Finish();
        }
    }

    public void Finish()
    {
        FinishGame.SetActive(true);
        if (p1score > p2score) FinishText.text = "Player1 win!";
        if (p1score < p2score) FinishText.text = "Player2 win!";
    }
}
