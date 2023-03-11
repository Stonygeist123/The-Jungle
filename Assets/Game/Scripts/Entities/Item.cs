using UnityEditor;
using UnityEngine;

public class ItemEntity : Entity
{
    public void Start()
    {
        transform.localScale = Vector3.one * .3f;
    }

    public static ItemEntity CreateItem(Item item, Vector3 position)
    {
        GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);
        go.AddComponent<ItemEntity>().Item = item;
        go.GetComponent<MeshRenderer>().material = item.Mat;
        go.transform.position = position + Vector3.up;
        Rigidbody rb = go.AddComponent<Rigidbody>();
        rb.useGravity = true;
        rb.mass = 3f;
        return go.GetComponent<ItemEntity>();
    }

    public override EntityType Type => EntityType.Item;
    public Item Item { get; set; }
}

public enum ItemKind
{
    None,
    Wood
}

public class Item
{
    public string Title { get => $"({count}) {kind}"; }
    public Material Mat => AssetDatabase.LoadAssetAtPath<Material>($"Assets/Textures/Items/{kind}.mat");
    public Item(ItemKind kind, ushort maxCount, ushort count)
    {
        this.kind = kind;
        this.maxCount = maxCount;
        this.count = count;
    }

    public ItemKind kind;
    public ushort maxCount;
    public ushort count;
}