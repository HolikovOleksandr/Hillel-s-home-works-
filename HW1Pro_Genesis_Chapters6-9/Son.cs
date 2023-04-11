public class Son : Noah
{
    public override string BuildArk()
    {
        return $"{Introduce()} get task from father and " + base.BuildArk();
    }
}
