using UnityEngine;
using UnityEngine.Events;
using UnityTools.ScriptableVariables;

public class GeneralMechs : MonoBehaviour
{
    private GenericInt score;
    private float timer;
    [SerializeField]
    private GenericFloat waitTime;

    public UnityEvent spawnObstacle;

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            spawnObstacle.Invoke();
            timer = waitTime.var;
        }
    }

}
