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
        if (toolT != null)
            tool = toolT.GetComponent<Tool>();
        else
            tool = null;
    }

    private void OnMouseDown()
    {
        UpdateTool();
        if (tool != null)
            switch (tool.toolKind)
            {
                case ToolKind.Axe:
                {
                    switch (transform.tag)
                    {
                        case "tree":
                            SendMessage($"TreeDamage", new Damage(GetComponent<Entity>().ID, 300));
                            break;
                    }
                    break;
                }
            }
    }
}
