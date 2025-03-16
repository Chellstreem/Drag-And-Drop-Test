using UnityEngine;

public class DecorativeObject : InteractableObject, IPlatform
{
    public SurfaceType SurfaceType{ get; private set; } = SurfaceType.Wooden;

    public void Construct(SurfaceType surfaceType)
    {
        SurfaceType = surfaceType;
    }
}
