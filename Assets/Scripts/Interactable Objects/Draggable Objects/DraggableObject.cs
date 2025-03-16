using UnityEngine;
using UnityEngine.EventSystems;
using Zenject;

[RequireComponent(typeof(Rigidbody2D))]
public class DraggableObject : InteractableObject, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    private IDragger dragger;
    private IPlacementHandler placementHandler;

    [SerializeField] private Collider2D standCollider;

    [Inject]
    public void Construct(IDragger dragger, IPlacementHandler placementHandler)
    {
        this.dragger = dragger;
        this.placementHandler = placementHandler;
        objectData = new ObjectData();
    }

    private void Awake()
    {         
        objectData.GeneralCollider = GetComponent<Collider2D>();
        objectData.StandCollider = standCollider;
        objectData.Rigidbody = GetComponent<Rigidbody2D>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        dragger.StartDrag(transform, eventData.position);
    }

    public void OnDrag(PointerEventData eventData)
    {
        dragger.Drag(eventData.position);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        dragger.StopDrag();
        placementHandler.HandlePlacement(ObjectData);
    }
}
