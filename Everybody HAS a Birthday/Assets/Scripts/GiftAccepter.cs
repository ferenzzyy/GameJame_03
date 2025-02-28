using System.Collections.Generic;
using UnityEngine;

public class GiftAccepter : MonoBehaviour
{

    private bool _orderFullfilled = false;
    private float _orderTimer = 10;

    private bool _correctOrder;

    private bool _currentOrderDone = false;

    private List<GameObject> _orders = new List<GameObject>();
    private List<bool> _ordersWantedWrapped = new List<bool>();

    UIManager _uiManager;

    private void Awake()
    {
        _uiManager = FindObjectOfType<UIManager>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Gift"))
        {
            // check for correct order
            Gift gift = collision.GetComponent<Gift>();

            if (gift != null)
            {
                for (int i = 0; i < _orders.Count; i++)
                {
                    if (gift.GetIsWrapped() == _ordersWantedWrapped[i] && gift.giftName == _orders[i].GetComponent<Order>().orderName)
                    {
                        _orderFullfilled = true;
                        Destroy(_orders[i]);    
                        Destroy(collision.gameObject);
                    }
                }

            }
            


        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < _orders.Count; i++)
        {
            if (_orders[i] == null)
            {
                _orders.RemoveAt(i);
                _ordersWantedWrapped.RemoveAt(i);
                _uiManager.RemoveOrderUI(i);
            }
        }
        CheckForOrders();

    }

    

    private void CheckForOrders()
    {
        if (!_currentOrderDone)
        {
            GiftTimer();
            if (!_orderFullfilled && _orderTimer < 0)
            {
                print("Order failed!");
                _currentOrderDone = true;
            }

            if (_orderFullfilled)
            {
                print("Order Success");
                _currentOrderDone = true;
                _orderFullfilled = false;
            }


        }
        _currentOrderDone = false;
    }

    private void GiftTimer()
    {
        if (_orderTimer > 0)
        {
            _orderTimer -= Time.deltaTime;
        }
        else
        {
            _orderTimer = 10;
            
        }
    }
    
    public void AddToOrders(GameObject order, bool ordersWrapped)
    {
        _orders.Add(order);
        _ordersWantedWrapped.Add(ordersWrapped);
    }

    public bool GetOrderDone()
    {
        return _orderFullfilled;
    }

    // Check if gift is placed here 
    // if the gift is equal to the requested on AND checks if it wrapped or not depending on the request
    // if this check good then player gets money/points 
    // if this check fails then player get -money/points
    // have a bool called orderFullfilled 
    // when this bool is false a timer starts 
    // if the timer = 0 and orderfullfilled = false then 
    // player doesnt get an points/money
}
