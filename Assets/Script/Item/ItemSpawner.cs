using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    
    public GameObject fieldItem;

    private void Start()
    {
        GameObject _Item = Instantiate(fieldItem, new Vector3(0, 0, 0), Quaternion.identity);
        _Item.GetComponent<FieldItem>().SetItem(ItemDB.instance.itemDB[1]);

        _Item = Instantiate(fieldItem,new Vector3 (1,0,0),Quaternion.identity);
        _Item.GetComponent<FieldItem>().SetItem(ItemDB.instance.itemDB[0]);
    }
}