using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityTools.ScriptableVariables;

public class GeneralMechs : MonoBehaviour
{
    private int score;

    [SerializeField]
    private float addScoreTime, skillWaitTime, powTime, spawnWaitTime;
    private float spawnTimer, scoreTimer, skillTimer, powTimer;
    [SerializeField]
    private GameObject playerGlow;

    [Header("UI Variables")]
    [SerializeField]
    private GameObject gameOverUI;
    [SerializeField]
    private Text textScoreGame, textScoreFinal;

    [Header("ScriptableVariables")]
    [SerializeField]
    private GenericFloat moveSpeed;
    [SerializeField]
    private GenericBool isPlaying;
    [SerializeField]
    private GenericBool powerActive;

    [Space]
    public UnityEvent spawnObstacle;

    void Start()
    {
        isPlaying.var = true;
        score = 0;
        moveSpeed.var = 0.15f;
        powerActive.var = false;

        powTimer = powTime;
    }

    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0f)
        {
            spawnObstacle.Invoke();
            spawnTimer = spawnWaitTime;
        }

        scoreTimer -= Time.deltaTime;
        if (scoreTimer <= 0f)
        {
            score += 10;
            textScoreGame.text = score.ToString();
            scoreTimer = addScoreTime;
        }

        skillTimer -= Time.deltaTime;
        if (skillTimer <= 0f)
        {
            IncreaseDifficulty();
            skillTimer = skillWaitTime;
        }

        if (powerActive.var)
        {
            if (!playerGlow.activeSelf)
            {
                playerGlow.SetActive(true);
            }
            powTimer -= Time.deltaTime;
            if (powTimer <= 0f)
            {
                powerActive.var = false;
                playerGlow.SetActive(false);
                powTimer = powTime;
            }
        }
    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        gameOverUI.SetActive(true);
        textScoreFinal.text = score.ToString();
        isPlaying.var = false;
    }

    private void IncreaseDifficulty()
    {
        if (spawnWaitTime >= 0.8)
        {
            spawnWaitTime -= 0.4f;
        }
        if (moveSpeed.var <= 0.28f)
        {
            moveSpeed.var += 0.02f;
        }
    }
}
