using UnityEngine;
using UnityTools.ScriptableVariables;

public class InitialTerrainMovement : MonoBehaviour
{
    [SerializeField]
    private GenericFloat terrainMoveSpeed = null;
    [SerializeField]
    private GenericBool isPlaying = null;

    [SerializeField]
    private float limitToDestroy = 0f;

    void Update()
    {
        if (isPlaying.var)
        {
            float step = Time.deltaTime * terrainMoveSpeed.var;
            transform.Translate(Vector3.left * terrainMoveSpeed.var);

            if (transform.position.x <= limitToDestroy)
            {
                Destroy(gameObject);
            }
        }
    }
}
