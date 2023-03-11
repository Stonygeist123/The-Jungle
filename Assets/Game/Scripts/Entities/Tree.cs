using UnityEngine;

public class Tree : Entity
{
    public override EntityType Type => EntityType.Tree;
    public override Item Drop => new(ItemKind.Wood, 64, (ushort)Mathf.Round(transform.localScale.z * 10));
    private void Start() => HP = (uint)Mathf.Round(transform.localScale.z) * 1000;
    public void TreeDamage(Damage dmg)
    {
        if (GetInstanceID() == dmg.ID)
        {
            if (HP <= dmg.Dmg)
            {
                DropItem();
                Destroy(gameObject);
            }
            else
                HP -= dmg.Dmg;
        }
    }
}
