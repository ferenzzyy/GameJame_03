using UnityEngine;

public class GiftComponent : MonoBehaviour
{
    public enum ComponentType {METAL, PLASTIC, ELECTRONIC };
    public ComponentType componentType;

    [SerializeField] Collider2D itemCol;

    public void DisableCollision() 
    { 
        itemCol.enabled = false;
    }

    public void EnableCollision() 
    {
        itemCol.enabled = true;
    }

    

}
