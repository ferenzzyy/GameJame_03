using UnityEngine;

public class Component : MonoBehaviour
{
    private enum ComponentType {METAL, PLASTIC, ELECTRONIC };

    [SerializeField] private ComponentType componentType;

    [SerializeField] Collider2D itemCol;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisableCollision() 
    {
        //collider2D = GetComponentInChildren<Collider2D>();
        itemCol.enabled = false;
    }

    public void EnableCollision() 
    {
        //collider2D = GetComponentInChildren<Collider2D>();
        itemCol.enabled = true;
    }

}
