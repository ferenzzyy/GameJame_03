using UnityEngine;

public class Crafter : MonoBehaviour
{
    private string[] components = {null};

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Interactable"))
        {
            GiftComponent _giftComp = collision.GetComponent<GiftComponent>();

            if (_giftComp != null) 
            {
                components[0] = _giftComp.componentType.ToString();

                

                


                //print(_giftComp.componentType.ToString());
                for (int i = 0; i < components.Length; i++)
                {
                    print(components[i]);
                    
                }
            }

            

        }
    }

}
