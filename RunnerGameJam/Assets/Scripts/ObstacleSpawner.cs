using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] obstacles;

    public void SpawnObstacle()
    {
        int rnd = Random.Range(0, obstacles.Length);
        GameObject newObstacle = Instantiate(obstacles[rnd]);
        newObstacle.transform.position = new Vector2(transform.position.x, newObstacle.transform.position.y);
    }

}
