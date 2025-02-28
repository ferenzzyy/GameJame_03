using UnityEngine;

public class GiftComponent : MonoBehaviour
{
    public enum ComponentType {METAL, PLASTIC, ELECTRONIC };
    public ComponentType componentType;

    [SerializeField] Sprite[] sp;

    private void Update()
    {
        switch (componentType) 
        {
            case ComponentType.METAL:
                gameObject.GetComponent<SpriteRenderer>().sprite = sp[0];
                break;
            case ComponentType.PLASTIC:
                gameObject.GetComponent<SpriteRenderer>().sprite = sp[1];
                break;
            case ComponentType.ELECTRONIC:
                gameObject.GetComponent<SpriteRenderer>().sprite = sp[2];
                break;
        }
    }

}
