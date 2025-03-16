using UnityEngine;

public class Dragger : IDragger
{
    private readonly Camera camera;

    private Vector3 offset;
    private Transform draggingObject;

    public Dragger(Camera camera)
    {
        this.camera = camera;
    }

    public void StartDrag(Transform targetjTransform, Vector3 pointerPosition)
    {
        draggingObject = targetjTransform;
        offset = targetjTransform.position - GetMouseWorldPosition(pointerPosition);
    }

    public void Drag(Vector3 pointerPosition)
    {
        if (draggingObject != null)
            draggingObject.position = GetMouseWorldPosition(pointerPosition) + offset;
    }

    public void StopDrag()
    {
        draggingObject = null;
    }

    private Vector3 GetMouseWorldPosition(Vector3 pointerPosition)
    {
        pointerPosition.z = Mathf.Abs(camera.transform.position.z);
        return camera.ScreenToWorldPoint(pointerPosition);
    }
}
