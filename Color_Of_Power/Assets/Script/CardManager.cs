using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CardManager : MonoBehaviour
{
    [SerializeField] public List<Card> AlienDeck = new List<Card>();
    [SerializeField] public List<Card> TerrestrialDeck = new List<Card>();



    [SerializeField] private TextMeshProUGUI RoundText;
    private int round = 0;

    [SerializeField] public Transform[] SlotCardP1;
    [SerializeField] public Transform[] SlotCardP2;

    [SerializeField] public Transform CardP1fight;
    [SerializeField] public Transform CardP2fight;

    private AudioSource Audio;

    //for playing one time
    bool PlayP1Sound;
    bool PlayP2Sound;

    private void Start()
    {
        Audio = GetComponent<AudioSource>();
    }



    public Card GetCardP1()
    {
        return ScoreManager._instance.GetCardP1();
    }
    public Card GetCardP2()
    {
        return ScoreManager._instance.GetCardP2();
    }

    public void draw()
    {
        for (int i = 0; i < SlotCardP2.Length; i++)
        {
            Card randomcardP1 = AlienDeck[Random.Range(0, 20)];
            randomcardP1.IsP1 = true;
            Instantiate(randomcardP1, SlotCardP1[i]);


            Card randomcardP2 = TerrestrialDeck[Random.Range(0, 20)];
            randomcardP2.IsP1 = false;
            Instantiate(randomcardP2, SlotCardP2[i]);
        }
        round++;
        RoundText.text = round.ToString();
    }

    public void MoveCardTOFight()
    {
        SetSoundBool();

        if (GetCardP1() != null)
        {

            Card P1 = GetCardP1();
            if (PlayP1Sound)
            {
                Audio.PlayOneShot(P1.GetCardSound());
                PlayP1Sound = false;
            }
            P1.transform.position = CardP1fight.position;
        }
        if (GetCardP2() != null)
        {

            Card P2 = GetCardP2();
            if (PlayP2Sound)
            {
                Audio.PlayOneShot(P2.GetCardSound());
                PlayP2Sound = false;
            }
            P2.transform.position = CardP2fight.position;
        }
    }

    private void SetSoundBool()
    {
        if (ChangeTurn.turn == ChangeTurn.TurnState.P1)
        {
            PlayP1Sound = true;
        }
        else
        {
            PlayP2Sound = true;
        }
    }
}
