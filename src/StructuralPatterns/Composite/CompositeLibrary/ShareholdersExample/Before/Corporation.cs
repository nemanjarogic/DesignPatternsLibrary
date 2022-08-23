namespace CompositeLibrary.ShareholdersExample.Before;

public class Corporation
{
    public string Name { get; set; } = string.Empty;
    public List<Person> Shareholders { get; set; } = new();
}
