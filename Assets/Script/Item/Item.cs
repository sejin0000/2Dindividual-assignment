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
    [Header("��ȣ")]
    public string Number;

    [Header("�̸�")]
    public string Name;

    [Header("�̹���")]
    public Sprite Image;

    [Header("Ÿ��")]
    public Itemtype Type;

    [Header("�ɷ�ġ")]
    public int Power;

    [Header("����")]
    public string Explanation;

    [Header("���� ����")]
    public int PurchasePrice;

    [Header("�Ǹ� ����")]
    public int SalePrice;
}
