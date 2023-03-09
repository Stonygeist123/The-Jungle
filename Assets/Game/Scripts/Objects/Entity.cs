using UnityEngine;

public enum EntityType
{
    None,
    Tree
}

public abstract class Entity : MonoBehaviour
{
    public abstract EntityType Type { get; }
    public int ID => GetInstanceID();
}
