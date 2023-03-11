using UnityEngine;

public enum EntityType
{
    None,
    Tree,
    Item
}

public abstract class Entity : MonoBehaviour
{
    public abstract EntityType Type { get; }
    public virtual Item Drop => null;
    public int ID => GetInstanceID();
    public uint? HP { get; set; } = null;
    public virtual ItemEntity DropItem() => ItemEntity.CreateItem(Drop, transform.position);
}
