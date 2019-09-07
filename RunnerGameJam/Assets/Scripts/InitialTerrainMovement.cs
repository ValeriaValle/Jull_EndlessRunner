using UnityEngine;
using UnityEngine.Events;
using UnityTools.ScriptableVariables;

public class InitialTerrainMovement : MonoBehaviour
{
    [SerializeField]
    private GenericFloat terrainMoveSpeed;

    [SerializeField]
    private float limitToDestroy;

    void Update()
    {
        float step = Time.deltaTime * terrainMoveSpeed.var;
        transform.Translate(Vector3.left * terrainMoveSpeed.var);

        if (transform.position.x <= limitToDestroy)
        {
            Destroy(gameObject);
        }
    }
}
