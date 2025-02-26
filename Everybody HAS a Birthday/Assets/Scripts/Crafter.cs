using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crafter : MonoBehaviour
{
    private List<string> _components = new List<string>();
    
    [SerializeField] private List<GameObject> completedGifts = new List<GameObject>();


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Interactable"))
        {
            GiftComponent _giftComp = collision.GetComponent<GiftComponent>();

            if (_giftComp != null && _components.Count < 3)
            {
                _components.Add(_giftComp.componentType.ToString());


                Destroy(collision.gameObject);

                string _resultRecipe = string.Join(", ", _components.ToArray());
                CheckForRecipe(_resultRecipe);

                for (int i = 0; i < _components.Count; i++)
                {
                    print(_resultRecipe);
                }
            }
            else
            {
                Destroy(collision.gameObject);
            } 

            

        }
    }


    private void CheckForRecipe(string _recipe)
    {
        switch (_recipe) 
        {
            case "METAL, METAL, METAL":
                // SPAWN IN TUNGSTEN CUBE
                print("CUBE!");
                break;
            case "METAL, METAL, PLASTIC":
                print("MODEL CAR!");
                break;
            case "METAL, METAL, ELECTRONIC":
                print("ROCKET");
                break;
            case "METAL, PLASTIC, ELECTRONIC":
                print("LAPTOP/RC-CAR");
                break;
            case "PLASTIC, PLASTIC, ELECTRONIC":
                print("PHONE");
                break;
            case "PLASTIC, ELECTRONIC, ELECTRONIC":
                print("TRANSFORMER");
                break;
            case "PLASTIC, PLASTIC, PLASTIC":
                print("VIYNL FIGURINE");
                break;
            case "PLASTIC, PLASTIC, METAL":
                print("SUPERHERO FIGURINE");
                break;
            case "ELECTRONIC, ELECTRONIC, METAL":
                print("POWER BANK");
                break;
            case "ELECTRONIC, ELECTRONIC, ELECTRONIC":
                print("ZEUS");
                break;

        }

    }

}
