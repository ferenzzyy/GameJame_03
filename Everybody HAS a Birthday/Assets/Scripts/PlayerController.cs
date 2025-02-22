using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D pRB;
    [SerializeField] private float playerSpeed = 20;

    private float _xInput;
    private float _yInput;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        pRB.velocity = new Vector2 (_xInput, _yInput) * playerSpeed * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        _xInput = Input.GetAxis("Horizontal");
        _yInput = Input.GetAxis("Vertical");

        print(new Vector2(_xInput, _yInput));
    }
}
