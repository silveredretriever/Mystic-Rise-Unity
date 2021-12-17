using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Item item;
    public SpriteRenderer sprite;

    void Start() 
    {
        sprite.sprite = item.icon;
    }

    void OnTriggerEnter2D()
    {
        Debug.Log("Picking up " + item.name);
        Inventory.instance.Add(item);
        GameObject.Find("Audio Manager").GetComponent<AudioManager>().Play("Pickup Item");
        Destroy(gameObject);
    }
}
