using UnityEngine;

public class Dispenser : MonoBehaviour
{
    private enum DispenserType { PLASTIC, METAL, ELECTRONIC };
    [SerializeField] private DispenserType dispenserType;

    [SerializeField] private GameObject component;

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
        }
    }



    private void DispensePlastic()
    {
        // Instantiate prefab of plastic component
        print("You Got a Plastic Component");

        GameObject _item = Instantiate(component, gameObject.transform);
        GiftComponent _itemType = _item.GetComponent<GiftComponent>();
        _itemType.componentType = GiftComponent.ComponentType.PLASTIC;
    }


    private void DispenseElectronics()
    {
        // Instantiate prefab of Electronic component
        print("You Got a Electronic Component");
        GameObject _item = Instantiate(component, gameObject.transform);
        GiftComponent _itemType = _item.GetComponent<GiftComponent>();
        _itemType.componentType = GiftComponent.ComponentType.ELECTRONIC;
    }

    private void DispenseMetal()
    {
        // Instantiate prefab of metal component
        print("You Got a Metal Component");
        GameObject _item = Instantiate(component, gameObject.transform);
        GiftComponent _itemType = _item.GetComponent<GiftComponent>();
        _itemType.componentType = GiftComponent.ComponentType.METAL;
    }

   
}
