using UnityEngine;

public class TerrainSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject terrain;
    private Transform spwner;

    void Start()
    {
        spwner = GetComponent<Transform>();
    }

    public void SpawnTerrain()
    {
        GameObject newTerrain = Instantiate(terrain);
        newTerrain.transform.position = new Vector2(spwner.position.x, newTerrain.transform.position.y);
    }
}
