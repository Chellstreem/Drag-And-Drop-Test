public class HouseholdAppliance : InteractableObject, IPlatform
{
    public SurfaceType SurfaceType { get; private set; } = SurfaceType.Plastic;

    public void Construct(SurfaceType surfaceType)
    {
        SurfaceType = surfaceType;
    }
}
