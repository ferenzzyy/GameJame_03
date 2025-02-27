using UnityEngine;

public class WrapDispenser : MonoBehaviour
{
    [SerializeField] private Transform giftStation;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Interactable"))
        {
            Gift _giftComp = collision.GetComponent<Gift>();

            if (_giftComp != null) 
            {
                _giftComp.SetIsWrapped(true);
            }

        }
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
