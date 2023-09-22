using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    public GameObject Inventory;
    public GameObject Status;

    public void OpenInventory()
    {
        Inventory.SetActive(true);
    }
    public void CloseInventory()
    {
        Inventory.SetActive(false);
    }

    public void OpenStatus()
    {
        Status.SetActive(true);
    }
    public void CloseStatus()
    {
        Status.SetActive(false);
    }
}
