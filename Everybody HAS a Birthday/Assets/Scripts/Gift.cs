using UnityEngine;

public class Gift : MonoBehaviour
{
    public enum GiftNames {
        TUNGSTEN_CUBE, 
        MODEL_CAR, 
        ROCKET, 
        LAPTOP,  
        PHONE, 
        TRANSFOMER, 
        SUPERHERO_FIGURINE,
        VIYNL_FIGURINE,
        POWER_BANK,
        ZEUS
    };
    
    public GiftNames giftName;
    
    private bool _isWrapped = false;

    private void OnEnable()
    {
        // switch statements for changing sprites based on gift
    }

    public bool GetIsWrapped()
    {
        return _isWrapped;
    }
    public void SetIsWrapped(bool wrapped) 
    { 
        _isWrapped = wrapped; 
    }

}
