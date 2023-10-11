using cherrydev;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInteraction : Interaction
{
    [SerializeField] private Inventory inventory;
    [SerializeField] private Item itemToAdd;
    protected override void OnInteract()
    {
        base.OnInteract();
        inventory.AddItem(itemToAdd);
        DisableInteract();
    }


    //private
    //public
    //protected
}
