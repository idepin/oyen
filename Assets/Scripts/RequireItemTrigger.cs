using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RequireItemTrigger : MonoBehaviour
{
    [SerializeField] private Item requireItem;
    [SerializeField] private Inventory inventory;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (inventory.HasItem(requireItem))
            {
                Debug.Log("PUNYA!!!");
            }
        }
    }
}
