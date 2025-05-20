using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CodexRoot
{
    public List<CodexCategory> categories;
}

[System.Serializable]
public class CodexCategory
{
    public string name;
    public List<CodexTopic> topics;
}

[System.Serializable]
public class CodexTopic
{
    public string name;
    public List<CodexEntry> entries;
}

[System.Serializable]
public class CodexEntry
{
    public string title;
    public string description;
    public string image;
}
