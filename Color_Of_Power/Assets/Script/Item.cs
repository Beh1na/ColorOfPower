using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] public AudioClip SoundFXCard;
    [SerializeField] public bool IsP1;

    [SerializeField] private bool useRockItem;


    private void OnMouseDown()
    {
        if (useRockItem) ScoreManager._instance.RockItem(IsP1);
        else ScoreManager._instance.RepairItem(IsP1);

        Destroy(gameObject);
    }


    public void destroyitself()
    {
        Destroy(gameObject);
    }
}
