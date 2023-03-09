using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform player;
    public Vector3 spawnPosition = new(250f, 52f, 250f);
    public GameObject tree;
    public int treeSpawnCount;
    public int xaxisT1, xaxisT2, zaxisT1, zaxisT2;

    void Start()
    {
        player.localPosition = spawnPosition;
        PlaceTrees();
    }

    Vector3 GeneratePosition()
    {
        int x = Random.Range(xaxisT1, xaxisT2);
        int z = Random.Range(zaxisT1, zaxisT2);
        return new Vector3(x, Terrain.activeTerrain.SampleHeight(new(x, 0, z)), z);
    }

    void PlaceTrees()
    {
        for (int i = 0; i < treeSpawnCount; ++i)
        {
            GameObject go = Instantiate(tree, GeneratePosition(), Quaternion.identity, Terrain.activeTerrain.transform);
            go.transform.Rotate(new Vector3(-90f, 0f, 0f));
            go.transform.localScale *= Random.Range(.5f, 5);
            go.AddComponent<Tree>();
            go.AddComponent<Hit>();
        }
    }
}
