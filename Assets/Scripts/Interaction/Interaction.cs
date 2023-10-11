using cherrydev;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    [SerializeField] private GameObject interactUI;

    private bool allowInteract;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        interactUI.SetActive(true);
        allowInteract = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        interactUI.SetActive(false);
        allowInteract = false;
    }

    private void Update()
    {
        if (allowInteract)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                OnInteract();
            }
        }
    }

    protected virtual void OnInteract()
    {
        interactUI.SetActive(false);
    }

    protected void DisableInteract()
    {
        interactUI.SetActive(false);
        gameObject.SetActive(false);
    }
}
