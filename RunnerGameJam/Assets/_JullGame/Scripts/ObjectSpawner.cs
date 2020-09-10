using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] obstacles = null;
    [SerializeField]
    private GameObject power = null;
    [SerializeField]
    private float powUpTime = 0f;
    private float timer;
    private bool spawnPow;

    void Start()
    {
        spawnPow = false;
        timer = powUpTime;
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            spawnPow = true;
            timer = powUpTime;
        }
    }

    public void SpawnObject()
    {
        if (!spawnPow)
        {
            int rnd = Random.Range(0, obstacles.Length);
            GameObject newObstacle = Instantiate(obstacles[rnd]);
            newObstacle.transform.position = new Vector2(transform.position.x, newObstacle.transform.position.y);
        }
        else
        {
            GameObject newPow = Instantiate(power);
            newPow.transform.position = new Vector2(transform.position.x, newPow.transform.position.y);
            spawnPow = false;
        }
    }
}
