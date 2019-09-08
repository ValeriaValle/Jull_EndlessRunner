using UnityEngine;
using UnityTools.ScriptableVariables;

public class PowerUp : MonoBehaviour
{
    [SerializeField]
    private GenericBool powerActive;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            powerActive.var = true;
        }
    }
}
