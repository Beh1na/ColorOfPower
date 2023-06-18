using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    [SerializeField] public int Score;
    [SerializeField] public AudioClip SoundFXCard;
    [SerializeField] public bool IsP1;

    private void OnMouseDown()
    {
        if(ChangeTurn.turn == ChangeTurn.TurnState.P1 && IsP1)
        {
            //if p1 card
            ScoreManager._instance.SetCardP1(this);
        }
        else if (ChangeTurn.turn == ChangeTurn.TurnState.P2 && !IsP1)
        {
            // if p2 card
            ScoreManager._instance.SetCardP2(this);
        }
    }

    public AudioClip GetCardSound()
    {
        return SoundFXCard;
    }


    public void destroyitself()
    {
        Destroy(gameObject);
    }
}
