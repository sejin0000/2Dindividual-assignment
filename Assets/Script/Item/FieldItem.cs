using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldItem : MonoBehaviour
{
    public SpriteRenderer image;
    public Item item;

    public void SetItem(Item _item)
    {
        item = _item;
        image.sprite = item.Image;
    }

    public Item GetItem()
    {
        return item;
    }

    public void DestroyItem()
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerItem>().PlayerInven.Add(item);
            collision.gameObject.GetComponent<PlayerItem>().AddSolt(item);
            DestroyItem();
        }
    }
}
