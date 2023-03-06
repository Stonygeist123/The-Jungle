using UnityEngine;

public class Tree : Entity
{
    public float hp;
    private void Start() => hp = transform.localScale.z * 1000;
    public void TreeDamage(Damage dmg)
    {
        Debug.Log(GetInstanceID());
        Debug.Log(dmg.ID);
        if (GetInstanceID() == dmg.ID)
        {
            hp -= dmg.Dmg;
            if (hp <= 0)
                Destroy(gameObject);
        }
    }
}
