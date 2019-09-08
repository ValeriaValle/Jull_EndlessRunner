﻿using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityTools.ScriptableVariables;

public class GeneralMechs : MonoBehaviour
{
    private int score;
    [SerializeField]
    private float addScoreTime, skillWaitTime, pUpTime;
    private float spawnTimer, scoreTimer, skillTimer, pUpTimer;

    //Scriptable Variables
    [SerializeField]
    private GenericFloat spawnWait;
    [SerializeField]
    private GenericFloat moveSpeed;
    [SerializeField]
    private GenericBool isPlaying;
    [SerializeField]
    private GenericBool powerActive;

    [Header("UI Variables")]
    [SerializeField]
    private GameObject gameOverUI;
    [SerializeField]
    private Text textScoreGame, textScoreFinal;

    [Space]
    public UnityEvent spawnObstacle;

    void Start()
    {
        isPlaying.var = true;
        score = 0;
        moveSpeed.var = 0.15f;
        spawnWait.var = 4f;
        powerActive.var = false;
    }

    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0f)
        {
            spawnObstacle.Invoke();
            spawnTimer = spawnWait.var;
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
            pUpTimer -= Time.deltaTime;
            if (pUpTimer <= 0f)
            {
                IncreaseDifficulty();
                pUpTimer = pUpTime;
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
        spawnWait.var -= 0.5f;
        moveSpeed.var += 0.02f;
    }
}