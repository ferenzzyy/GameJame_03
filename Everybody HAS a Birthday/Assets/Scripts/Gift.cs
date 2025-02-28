using UnityEngine;

public class Gift : MonoBehaviour
{
    [SerializeField] Sprite giftSprite;
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

    private void Update()
    {
        if (_isWrapped)
        {
            Sprite _sprite = gameObject.GetComponent<SpriteRenderer>().sprite;
             _sprite = giftSprite;
            

        }
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
