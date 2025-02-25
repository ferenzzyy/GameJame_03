using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    private bool _canInteract;
    private string _ObjName;
    private Dispenser _dispenser;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Interactable"))
        {
            _dispenser = collision.GetComponent<Dispenser>();
            _canInteract = true;
            _ObjName = collision.gameObject.name;



        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Interactable"))
        {

            _canInteract = false;
            _ObjName = null;
            
            
        }
    }

    private void Update()
    {
       
    }


    



    public bool GetCanInteract()
    {
        return _canInteract;
    }

    public void SetCanInteract(bool interact)
    {
        _canInteract = interact;
    }

    public string GetObjName() 
    {
        return _ObjName;
    }

    public Dispenser GetDispenser() 
    {
        return _dispenser;
    }
}
