using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    [SerializeField] public List<Item> ItemList = new List<Item>();

    [SerializeField] public Transform SlotItemP1;
    [SerializeField] public Transform SlotItemP2;

    public void DrawItem()
    {
        Item P1Item = ItemList[Random.Range(0,2)];
        P1Item.IsP1 = true;
        Instantiate(P1Item, SlotItemP1);

        Item P2Item = ItemList[Random.Range(0, 2)];
        P2Item.IsP1 = false;
        Instantiate(P2Item, SlotItemP2);
    }

}
