using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dispenser : MonoBehaviour
{
    private enum DispenserType { PLASTIC, METAL, ELECTRONIC, WRAPPER };
    [SerializeField] private DispenserType dispenserType;

    [SerializeField] private GameObject component;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DispenseComponent() 
    {
        switch (dispenserType)
        {
            case DispenserType.PLASTIC:
                DispensePlastic();
                break;
            case DispenserType.ELECTRONIC:
                DispenseElectronics();
                break;
            case DispenserType.METAL:
                DispenseMetal();
                break;
            case DispenserType.WRAPPER:
                DispenseWrapper();
                break;
        }
    }



    private void DispensePlastic()
    {
        // Instantiate prefab of plastic component
        print("You Got a Plastic Component");
    }


    private void DispenseElectronics()
    {
        // Instantiate prefab of Electronic component
        print("You Got a Electronic Component");
    }

    private void DispenseMetal()
    {
        // Instantiate prefab of metal component
        print("You Got a Metal Component");
    }

    private void DispenseWrapper()
    {
        // Instantiate prefab of wrapper
        print("You Got a Wrapper Component");
    }
}
