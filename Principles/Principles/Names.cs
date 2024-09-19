


class Names
{
    public List<string> All { get; } = new List<string>();
    private readonly NamesValidator _namesValidator = new();

    public void AddNames(List<string> names)
    {
        foreach (var name in names)
        {
            AddName(name);
        }
    }
    public void AddName(string name)
    {
        if (_namesValidator.IsValid(name))
        {
            All.Add(name);
        }
    }


}
