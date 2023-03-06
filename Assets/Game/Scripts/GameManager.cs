using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform player;
    public Vector3 spawnPosition = new Vector3(250f, 52f, 250f);
    void Start() => player.localPosition = spawnPosition;
}
