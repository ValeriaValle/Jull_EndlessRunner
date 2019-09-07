using UnityEngine;
using UnityEngine.Events;
using UnityTools.ScriptableVariables;

public class TerrainMovement : MonoBehaviour
{
    [SerializeField]
    private GenericFloat terrainMoveSpeed;

    [SerializeField]
    private float limitToSpawn, limitToDestroy;

    private bool spawned;
    public UnityEvent spawn;

    void Start()
    {
        spawned = false;
    }

    void Update()
    {
        float step = Time.deltaTime * terrainMoveSpeed.var;
        transform.Translate(Vector3.left * terrainMoveSpeed.var);

        if (transform.position.x <= limitToSpawn && !spawned)
        {
            spawn.Invoke();
            spawned = true;
        }

        if (transform.position.x <= limitToDestroy)
        {
            Destroy(gameObject);
        }
    }
}
