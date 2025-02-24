using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    private bool _canInteract;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Interactable"))
        {
            _canInteract = true;

        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Interactable"))
        {
            _canInteract = false;
            
        }
    }

    public bool GetCanInteract()
    {
        return _canInteract;
    }

    public void SetCanInteract(bool interact)
    {
        _canInteract = interact;
    }
}
