using UnityEngine;

public abstract class Entity : MonoBehaviour
{
    public int ID => GetInstanceID();
}
