using UnityEngine;

public class TerrainSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject terrain = null;

    public void SpawnTerrain()
    {
        GameObject newTerrain = Instantiate(terrain);
        newTerrain.transform.position = new Vector2(transform.position.x, newTerrain.transform.position.y);
    }
}
