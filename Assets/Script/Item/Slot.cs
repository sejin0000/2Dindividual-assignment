using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public Item item;
    public GameObject itemImage;

    private void Start()
    {
        itemImage.GetComponent<Image>().sprite = item.Image;
        transform.localScale = Vector3.one;
    }
}
