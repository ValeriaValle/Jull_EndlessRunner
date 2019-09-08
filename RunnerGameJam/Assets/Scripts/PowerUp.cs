using UnityEngine;
using UnityTools.ScriptableVariables;

public class PowerUp : MonoBehaviour
{
    [SerializeField]
    private GenericBool powerActive, isPlaying;
    [SerializeField]
    private GenericFloat moveSpeed;
    [SerializeField]
    private float limitToDestroy;

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
