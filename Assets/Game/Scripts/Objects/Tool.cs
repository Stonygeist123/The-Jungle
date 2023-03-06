using UnityEngine;

public enum ToolKind
{
    None,
    Axe,
    Unknown
}

public class Tool : MonoBehaviour
{
    public string toolName;
    public ToolKind toolKind = ToolKind.None;
    void Start()
    {
        toolName = transform.name;
        toolKind = toolKind != ToolKind.None ? toolKind : toolName switch
        {
            "axe" => ToolKind.Axe,
            _ => ToolKind.Unknown,
        };
    }
}
