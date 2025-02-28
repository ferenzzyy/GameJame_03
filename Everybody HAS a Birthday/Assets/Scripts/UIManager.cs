using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] TextMeshProUGUI moneyText;

    private List<Gift.GiftNames> orderNames = new List<Gift.GiftNames>();
    private List<bool> giftsToBeWrapped = new List<bool>();

    // To enable which recipe to show
    [SerializeField] List<Image> customerOrders = new List<Image>();

    // Store different recipe sprites
    [SerializeField] Sprite[] orderRecipes;

   

    private void Update()
    {
        CheckRecipeToDisplay();
    }

    private void CheckRecipeToDisplay()
    {
        for (int i = 0; i < orderNames.Count; i++)
        {
            switch (orderNames[i])
            {
                case Gift.GiftNames.TUNGSTEN_CUBE:
                    // check if it needs to be wrapped
                    customerOrders[i].sprite = orderRecipes[0];
                    break;
                case Gift.GiftNames.MODEL_CAR:
                    customerOrders[i].sprite = orderRecipes[1];
                    break;
                case Gift.GiftNames.ROCKET:
                    customerOrders[i].sprite = orderRecipes[2];
                    break;
                case Gift.GiftNames.LAPTOP:
                    customerOrders[i].sprite = orderRecipes[3];
                    break;
                case Gift.GiftNames.PHONE:
                    customerOrders[i].sprite = orderRecipes[4];
                    break;
                case Gift.GiftNames.TRANSFOMER:
                    customerOrders[i].sprite = orderRecipes[5];
                    break;
                case Gift.GiftNames.VIYNL_FIGURINE:
                    customerOrders[i].sprite = orderRecipes[6];
                    break;
                case Gift.GiftNames.SUPERHERO_FIGURINE:
                    customerOrders[i].sprite = orderRecipes[7];
                    break;
                case Gift.GiftNames.POWER_BANK:
                    customerOrders[i].sprite = orderRecipes[8];
                    break;
                case Gift.GiftNames.ZEUS:
                    customerOrders[i].sprite = orderRecipes[9];
                    break;

            }
        }
    }

    public void AddToOrderUI(Gift.GiftNames order, bool wrappedOrNot)
    {
        orderNames.Add(order);
        giftsToBeWrapped.Add(wrappedOrNot);
    }

    public void RemoveOrderUI(int index)
    {
        orderNames.RemoveAt(index);
        giftsToBeWrapped.RemoveAt(index);
        customerOrders[index].sprite = null;
    }
}
