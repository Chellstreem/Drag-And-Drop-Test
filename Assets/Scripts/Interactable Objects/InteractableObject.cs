using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public abstract class InteractableObject : MonoBehaviour
{
    protected ObjectData objectData;
    public ObjectData ObjectData => objectData;

    public virtual void Interact()
    {
        Debug.Log($"Hi, it's {gameObject.name}!");
    }    
}


