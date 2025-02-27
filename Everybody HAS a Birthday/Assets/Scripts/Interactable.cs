using UnityEngine;

public class Interactable : MonoBehaviour
{
    private bool _canInteract;
    private string _ObjName;
    private Dispenser _dispenser;

    private GameObject _item;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Interactable"))
        {
            _dispenser = collision.GetComponent<Dispenser>();
            _canInteract = true;
            //_ObjName = collision.gameObject.name;
            _item = collision.gameObject;



        }
        if (collision.CompareTag("Gift"))
        {

            _canInteract = true;
            //_ObjName = collision.gameObject.name;
            _item = collision.gameObject;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Interactable"))
        {
            _dispenser = null;
            _canInteract = false;
            //_ObjName = null;
            _item = null;
            
            
        }
        if (collision.CompareTag("Gift"))
        {
            _canInteract = false;
            //_ObjName = null;
            _item = null;
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

    public string GetObjName() 
    {
        return _ObjName;
    }

    public Dispenser GetDispenser() 
    {
        return _dispenser;
    }

    public GameObject GetItem() 
    {
        return _item;
    }
}
