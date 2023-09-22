using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public enum Itemtype
{
    Weapon,
    Armor,
}

[System.Serializable]
public class Item
{
    [Header("번호")]
    public string Number;

    [Header("이름")]
    public string Name;

    [Header("이미지")]
    public Sprite Image;

    [Header("타입")]
    public Itemtype Type;

    [Header("능력치")]
    public int Power;

    [Header("설명")]
    public string Explanation;

    [Header("구매 가격")]
    public int PurchasePrice;

    [Header("판매 가격")]
    public int SalePrice;
}
