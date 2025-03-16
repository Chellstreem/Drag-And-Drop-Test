using UnityEngine;

[CreateAssetMenu(fileName = "GameConfig", menuName = "Scriptable Objects/Game Config")]
public class GameConfig : ScriptableObject, IPlacementConfig, IDroppingConfig
{
    [Header("Placement Config")]
    [SerializeField] private LayerMask placementLayer; 
    public LayerMask PlacementLayer => placementLayer;    

    //

    [Header("Dropping Config")]
    [SerializeField] private float gravityScale = 1f;    
    public float GravityScale => gravityScale;
}
