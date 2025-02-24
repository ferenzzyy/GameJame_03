using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D pRB;
    [SerializeField] private float playerSpeed = 20;

    Interactable interact;

    private float _xInput;
    private float _yInput;

    private void Awake()
    {
        interact = GetComponent<Interactable>();
    }

    // Start is called before the first frame update
    void Start()
    {

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

        if (Input.GetKeyDown(KeyCode.E) && interact.GetCanInteract())
        {
            print("Interacted!");


        }

    }

}
