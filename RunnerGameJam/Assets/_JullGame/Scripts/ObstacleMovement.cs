using UnityEngine;
using UnityTools.ScriptableVariables;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField]
    private GenericFloat moveSpeed = null;
    [SerializeField]
    private GenericBool isPlaying = null;

    [SerializeField]
    private float limitToDestroy = 0f;

    void Update()
    {
        if (isPlaying.var)
        {
            float step = Time.deltaTime * moveSpeed.var;
            transform.Translate(Vector3.left * moveSpeed.var);

            if (transform.position.x <= limitToDestroy)
            {
                Destroy(gameObject);
            }
        }
    }
}
