using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerGenerator : MonoBehaviour
{
    [SerializeField] GameObject customer;
    [SerializeField] float timeToSpawn;
    [SerializeField] GiftAccepter giftAccept;

    private List<GameObject> _customersSpawned = new List<GameObject>();
    private float _spawnCountdown;

    void Start()
    {
        _spawnCountdown = timeToSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        _spawnCountdown -= Time.deltaTime;
        if (_customersSpawned.Count != 4)
        {
            if (_spawnCountdown <= 0)
            {
                _spawnCountdown = timeToSpawn;
                SpawnCustomers();

            }
            
        }
        else
        {
            _spawnCountdown = 0;    
        }



        for (int i = 0; i < _customersSpawned.Count; i++)
        {
            if (_customersSpawned[i] == null)
            {
                _customersSpawned.RemoveAt(i);
            }
        }

    }

    private void SpawnCustomers()
    {
        Gift.GiftNames orderType = (Gift.GiftNames)Random.Range(0, 11);
        int _orderWrapped = Random.Range(1, 3);

        print(_orderWrapped);

        GameObject _customerSpawned = Instantiate(customer);
        Order order = _customerSpawned.GetComponent<Order>();
        order.orderName = orderType;

        if (_orderWrapped == 1)
        {
            order.SetWantedWrapped(true);
        }
        if (_orderWrapped == 2)
        {
            order.SetWantedWrapped(false);

        }

        _customersSpawned.Add(_customerSpawned);

        giftAccept.AddToOrders(_customerSpawned, order.GetWantedWrapped());

    }


}
