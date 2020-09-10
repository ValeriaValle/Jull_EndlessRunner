using UnityEngine;
using UnityTools.ScriptableVariables;

public class PowerUp : MonoBehaviour
{
    [SerializeField]
    private GenericBool powerActive = null, isPlaying = null;
    [SerializeField]
    private GenericFloat moveSpeed = null;
    [SerializeField]
    private float limitToDestroy = 0;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            powerActive.var = true;
            Destroy(gameObject);
        }
    }

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
