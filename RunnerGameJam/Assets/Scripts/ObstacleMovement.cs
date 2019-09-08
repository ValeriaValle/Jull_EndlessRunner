using UnityEngine;
using UnityEngine.Events;
using UnityTools.ScriptableVariables;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField]
    private GenericFloat moveSpeed;

    [SerializeField]
    private float limitToDestroy;

    void Update()
    {
        float step = Time.deltaTime * moveSpeed.var;
        transform.Translate(Vector3.left * moveSpeed.var);

        if (transform.position.x <= limitToDestroy)
        {
            Destroy(gameObject);
        }
    }
}
