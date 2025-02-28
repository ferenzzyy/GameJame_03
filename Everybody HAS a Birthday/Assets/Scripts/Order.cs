using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Order : MonoBehaviour
{
    public Gift.GiftNames orderName;

    [SerializeField] bool wantedWrapped;

    public bool GetWantedWrapped()
    {
        return wantedWrapped;
    }

    public void SetWantedWrapped(bool wrapped)
    {
        wantedWrapped = wrapped;
    }
}
