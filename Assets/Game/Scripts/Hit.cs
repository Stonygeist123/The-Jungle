using UnityEngine;

public class Hit : MonoBehaviour
{
    private Tool tool;
    private void Start()
    {
        if (GameObject.FindGameObjectWithTag("tool") != null)
            UpdateTool();
    }

    private void UpdateTool()
    {
        Transform toolT = GameObject.FindGameObjectWithTag("tool").transform;
        tool = toolT == null ? null : toolT.GetComponent<Tool>();
    }

    private void OnMouseDown()
    {
        UpdateTool();
        if (tool != null && Vector3.Distance(transform.position, tool.transform.position) <= 3f)
            switch (tool.toolKind)
            {
                case ToolKind.Axe:
                {
                    switch (GetComponent<Entity>().Type)
                    {
                        case EntityType.Tree:
                            SendMessage($"TreeDamage", new Damage(GetComponent<Entity>().ID, 300));
                            break;
                    }
                    break;
                }
            }
    }
}
