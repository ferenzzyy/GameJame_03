using UnityEngine;

public class HoldableItem : MonoBehaviour
{
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
