using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform player;
    void Start() => player.localPosition = new(0f, 1.8f, 0f);
}
