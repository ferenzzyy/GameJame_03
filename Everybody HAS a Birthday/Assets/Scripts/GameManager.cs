using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager manager;
    private static int money;
    private void Awake()
    {
        if (manager == null)
        {
            manager = this;
            DontDestroyOnLoad(this);
        }
        else if (manager != this)
        {
            Destroy(gameObject);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void AddMoney(int moneyToAdd)
    {
        money += moneyToAdd;
    }

    public static int GetMoney() 
    {
        return money;
    }

    public static void ResetMoney()
    {
        money = 0;
    }
}
