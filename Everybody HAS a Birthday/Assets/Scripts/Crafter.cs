using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crafter : MonoBehaviour
{
    private List<string> _components = new List<string>();
    
    [SerializeField] private List<GameObject> completedGifts = new List<GameObject>();

    private string _resultRecipe;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Interactable"))
        {
            GiftComponent _giftComp = collision.GetComponent<GiftComponent>();

            if (_giftComp != null && _components.Count < 3)
            {
                _components.Add(_giftComp.componentType.ToString());
                Destroy(collision.gameObject);

                _resultRecipe = string.Join(", ", _components.ToArray());

                for (int i = 0; i < _components.Count; i++)
                {
                    print(_resultRecipe);
                }
            }
            else
            {
                Destroy(collision.gameObject);
            } 
            CheckForRecipe(_resultRecipe);

            

        }
    }


    private void CheckForRecipe(string _recipe)
    {
        switch (_recipe) 
        {
            case "METAL, METAL, METAL":
                // SPAWN IN TUNGSTEN CUBE
                print("CUBE!");
                _components.Clear();
                break;
            case "METAL, METAL, PLASTIC":
                print("MODEL CAR!");
                _components.Clear();
                break;
            case "METAL, METAL, ELECTRONIC":
                print("ROCKET");
                _components.Clear();
                break;
            case "METAL, PLASTIC, ELECTRONIC":
                print("LAPTOP/RC-CAR");
                _components.Clear();
                break;
            case "PLASTIC, PLASTIC, ELECTRONIC":
                print("PHONE");
                _components.Clear();
                break;
            case "PLASTIC, ELECTRONIC, ELECTRONIC":
                _components.Clear();
                print("TRANSFORMER");
                break;
            case "PLASTIC, PLASTIC, PLASTIC":
                _components.Clear();
                print("VIYNL FIGURINE");
                break;
            case "PLASTIC, PLASTIC, METAL":
                print("SUPERHERO FIGURINE");
                _components.Clear();
                break;
            case "ELECTRONIC, ELECTRONIC, METAL":
                print("POWER BANK");
                _components.Clear();
                break;
            case "ELECTRONIC, ELECTRONIC, ELECTRONIC":
                print("ZEUS");
                _components.Clear();
                break;
            default:
                if (_components.Count == 3)
                {
                    print("Invalid recipe");
                    _components.Clear();
                    
                }
                break;
        }

    }

}
