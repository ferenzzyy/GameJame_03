using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D pRB;
    [SerializeField] private float playerSpeed = 20;
    [SerializeField] private Transform hands;

    Interactable interact;
    GameObject item;

    private float _xInput;
    private float _yInput;

    private void Awake()
    {
        interact = GetComponent<Interactable>();
    }

    private void FixedUpdate()
    {
        // Applying Player movement with input and speed
        pRB.velocity = new Vector2(_xInput, _yInput) * playerSpeed * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        InputHandler();


    }


    private void InputHandler()
    {
        // Player Input 
        _xInput = Input.GetAxis("Horizontal");
        _yInput = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.E) && interact.GetCanInteract() && item == null)
        {
            Dispenser dispenser = interact.GetDispenser();
            // Checks if the object interacted with is a dispenser or item
            if (dispenser != null) 
            { 
                dispenser.DispenseComponent();
            }
            else
            {   
                HoldItem();
            }

        }
        else if (Input.GetKeyDown(KeyCode.E) )
        {
            ReleaseItem();
        }

    }

    private void HoldItem() 
    {
        item = interact.GetItem();
        HoldableItem _item = item.GetComponent<HoldableItem>();
        _item.DisableCollision();

        item.transform.position = hands.position;
        item.transform.SetParent(hands);
        
        
    }
    private void ReleaseItem() 
    {
        if (item != null) 
        {
            HoldableItem _item = item.GetComponent<HoldableItem>();
            _item.EnableCollision();

            item.transform.SetParent(null);
            item = null;
        }
        
    }

}
