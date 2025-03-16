using UnityEngine;

public class Dropper : IDropper
{
    private readonly float gravityScale;

    public Dropper(IDroppingConfig config)
    {
        gravityScale = config.GravityScale;
    }

    public void Drop(Rigidbody2D itemRb)
    {
        itemRb.gravityScale = gravityScale;
    }
}
