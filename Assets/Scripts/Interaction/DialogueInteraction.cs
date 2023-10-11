using cherrydev;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueInteraction : Interaction
{
    [SerializeField] private DialogBehaviour dialogBehaviour;
    [SerializeField] private DialogNodeGraph dialogNodeGraph;
    [SerializeField] private PlayerController playerController;

    protected override void OnInteract()
    {
        base.OnInteract();
        dialogBehaviour.StartDialog(dialogNodeGraph);
        playerController.AllowMove = false;
    }

    
}
