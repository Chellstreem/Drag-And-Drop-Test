using UnityEngine;
using UnityEngine.UIElements;

public class PlacementHandler : IPlacementHandler
{
    private readonly IDropper dropper;
    private readonly LayerMask placementLayer;

    private readonly float angle = 0f;

    public PlacementHandler(IDropper dropper, IPlacementConfig config)
    {
        this.dropper = dropper;
        placementLayer = config.PlacementLayer;
    }

    public void HandlePlacement(ObjectData objectData)
    {
        Collider2D standCollider = objectData.StandCollider;

        Vector2 point = standCollider.bounds.center;
        Vector2 size = standCollider.bounds.size;        

        Collider2D hit = Physics2D.OverlapBox(point, size, angle, placementLayer);
        if (hit == null)
        {
            dropper.Drop(objectData.Rigidbody);
            return;
        }

        if (hit.TryGetComponent(out IPlatform platform) && IsColliderFullyInside(standCollider, hit))
        {
            Debug.Log($"Звук столкновения с типом поверхности {platform.SurfaceType}!");
        }
    }

    private bool IsColliderFullyInside(Collider2D inner, Collider2D outer)
    {
        Bounds innerBounds = inner.bounds;
        Bounds outerBounds = outer.bounds;

        bool minInside = outerBounds.min.x <= innerBounds.min.x && outerBounds.min.y <= innerBounds.min.y;
        bool maxInside = outerBounds.max.x >= innerBounds.max.x && outerBounds.max.y >= innerBounds.max.y;
        
        return minInside && maxInside;
    }
}
