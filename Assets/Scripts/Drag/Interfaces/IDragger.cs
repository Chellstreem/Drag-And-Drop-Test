using UnityEngine;

public interface IDragger
{
    public void StartDrag(Transform targetjTransform, Vector3 pointerPosition);
    public void Drag(Vector3 pointerPosition);
    public void StopDrag();
}
