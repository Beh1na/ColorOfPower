using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTurn : MonoBehaviour
{
    public enum TurnState { P1, P2 }

    static public TurnState turn;

    [SerializeField] private GameObject AlienObject;
    [SerializeField] private GameObject EarthObject;

    public Card GetCardP1()
    {
        return ScoreManager._instance.GetCardP1();
    }
    public Card GetCardP2()
    {
        return ScoreManager._instance.GetCardP2();
    }

    void Start()
    {
        turn = TurnState.P1;
    }

    public void changeTurn()
    {
        if (GetCardP1() == null && GetCardP2() == null)
            return;
        if(GetCardP1() != null && GetCardP2() == null)
            turn = TurnState.P2;
        if (GetCardP1() == null && GetCardP2() != null) 
            turn = TurnState.P1;

        Debug.Log(turn);
    }

    public void SetObject()
    {
        if(turn == TurnState.P1)
        {
            AlienObject.SetActive(true);
            EarthObject.SetActive(false);

        }
        else
        {
            AlienObject.SetActive(false);
            EarthObject.SetActive(true);

        }
    }
    public void SetObjectIntro()
    {
        if (turn == TurnState.P1)
        {
            AlienObject.SetActive(true);
            EarthObject.SetActive(false);

        }
        else
        {
            AlienObject.SetActive(false);
            EarthObject.SetActive(true);

        }
    }

}
