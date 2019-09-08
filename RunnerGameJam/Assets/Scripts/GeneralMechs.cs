using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityTools.ScriptableVariables;

public class GeneralMechs : MonoBehaviour
{
    private GenericInt score;
    private float timer;
    [SerializeField]
    private GenericFloat waitTime;
    [SerializeField]
    private GenericBool isPlaying;

    [Header("UI Variables")]
    [SerializeField]
    private GameObject gameOverUI;

    [Space]
    public UnityEvent spawnObstacle;

    void Start()
    {
        isPlaying.var = true;
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            spawnObstacle.Invoke();
            timer = waitTime.var;
        }
    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        gameOverUI.SetActive(true);
        isPlaying.var = false;
    }
}
