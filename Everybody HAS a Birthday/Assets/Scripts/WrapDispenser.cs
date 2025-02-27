using UnityEngine;

public class WrapDispenser : MonoBehaviour
{
    [SerializeField] private Transform giftStation;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Gift"))
        {
            Gift _gift = collision.GetComponent<Gift>();

            if (_gift != null && !_gift.GetIsWrapped()) 
            {
                HoldGift(collision.transform);
                _gift.SetIsWrapped(true);
            }

            

        }
    }

    private void HoldGift(Transform gift)
    {
        
        gift.position = giftStation.position;
        gift.SetParent(giftStation);
    }
    private void ReleaseGift(Transform gift)
    {
        gift.SetParent(null);
    }

    // TODO create Ienumerator for wrapping.
    // Set gift position to giftStation transform 
    // Wait for x amount of time
    // have an Iswrapping bool 
    // while IsWrapping = true player cant hold item
    // after wait time is over set is wrapped to true
    // IsWrapping = false
    // Player can hold gift

    
    


}
