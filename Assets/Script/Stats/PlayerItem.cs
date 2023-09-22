using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerItem : MonoBehaviour
{
    public List<Item> PlayerInven = new List<Item>();
    public RectTransform Inventroy;
    public GameObject slot;

    public void AddSolt(Item item)
    {
        GameObject _slot = Instantiate(slot);
        _slot.GetComponent<Slot>().item = item;
        _slot.transform.SetParent(Inventroy);
    }
}