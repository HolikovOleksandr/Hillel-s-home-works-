public abstract class BiblicallyCharacter : IArkBuilder, IMarried
{
    public string? Name { get; set; }
    public string? SonOf { get; set; }
    public bool IsMerried { get; set; }

    public string Introduce() => $"{Name} son of {SonOf}";

    public virtual string BuildArk() => "starts building the ark";

    public string InviteWifeIntoArk()
    {
        if(IsMerried) return $"{Name} invite her wife on unforgettable cruise";
        else return $"{Name} entered the ark alone";
    }
}
