using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Component : MonoBehaviour
{
    private enum ComponentType {METAL, PLASTIC, ELECTRONIC };

    [SerializeField] private ComponentType componentType;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
