using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crafter : MonoBehaviour
{
    private List<string> _components = new List<string>();

    //[SerializeField] private List<GameObject> completedGifts = new List<GameObject>();
    [SerializeField] private GameObject gift;
    [SerializeField] private Transform giftSpawnOffset;

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
        Gift _giftComp;
        
        switch (_recipe) 
        {
            case "METAL, METAL, METAL":
                GameObject _gift = Instantiate(gift, giftSpawnOffset.transform);
                _giftComp = _gift.GetComponent<Gift>();
                _giftComp.giftName = Gift.GiftNames.TUNGSTEN_CUBE;

                print("CUBE!");
                _components.Clear();
                break;

            case "METAL, METAL, PLASTIC":
                GameObject _gift1 = Instantiate(gift, giftSpawnOffset.transform);
                _giftComp = _gift1.GetComponent<Gift>();
                _giftComp.giftName = Gift.GiftNames.MODEL_CAR;

                print("MODEL CAR!");
                _components.Clear();
                break;

            case "METAL, METAL, ELECTRONIC":
                GameObject _gift2 = Instantiate(gift, giftSpawnOffset.transform);
                _giftComp = _gift2.GetComponent<Gift>();
                _giftComp.giftName = Gift.GiftNames.ROCKET;

                print("ROCKET");
                _components.Clear();
                break;

            case "METAL, PLASTIC, ELECTRONIC":
                GameObject _gift3 = Instantiate(gift, giftSpawnOffset.transform);
                _giftComp = _gift3.GetComponent<Gift>();
                _giftComp.giftName = Gift.GiftNames.LAPTOP;

                print("LAPTOP/RC-CAR");
                _components.Clear();
                break;

            case "PLASTIC, PLASTIC, ELECTRONIC":
                GameObject _gift4 = Instantiate(gift, giftSpawnOffset.transform);
                _giftComp = _gift4.GetComponent<Gift>();
                _giftComp.giftName = Gift.GiftNames.PHONE;

                print("PHONE");
                _components.Clear();
                break;

            case "PLASTIC, ELECTRONIC, ELECTRONIC":
                GameObject _gift5 = Instantiate(gift, giftSpawnOffset.transform);
                _giftComp = _gift5.GetComponent<Gift>();
                _giftComp.giftName = Gift.GiftNames.TRANSFOMER;

                _components.Clear();
                print("TRANSFORMER");
                break;

            case "PLASTIC, PLASTIC, PLASTIC":
                GameObject _gift6 = Instantiate(gift, giftSpawnOffset.transform);
                _giftComp = _gift6.GetComponent<Gift>();
                _giftComp.giftName = Gift.GiftNames.VIYNL_FIGURINE;

                _components.Clear();
                print("VIYNL FIGURINE");
                break;

            case "PLASTIC, PLASTIC, METAL":
                GameObject _gift7 = Instantiate(gift, giftSpawnOffset.transform);
                _giftComp = _gift7.GetComponent<Gift>();
                _giftComp.giftName = Gift.GiftNames.SUPERHERO_FIGURINE;

                print("SUPERHERO FIGURINE");
                _components.Clear();
                break;

            case "ELECTRONIC, ELECTRONIC, METAL":
                GameObject _gift8 = Instantiate(gift, giftSpawnOffset.transform);
                _giftComp = _gift8.GetComponent<Gift>();
                _giftComp.giftName = Gift.GiftNames.POWER_BANK;


                print("POWER BANK");
                _components.Clear();
                break;

            case "ELECTRONIC, ELECTRONIC, ELECTRONIC":
                GameObject _gift9 = Instantiate(gift, giftSpawnOffset.transform);
                _giftComp = _gift9.GetComponent<Gift>();
                _giftComp.giftName = Gift.GiftNames.ZEUS;

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
