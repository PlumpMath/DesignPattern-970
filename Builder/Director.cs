public class Director
{
    private Builder builder;

    public Director(Builder builder)
    {
        this.builder = builder;
    }

    public void Construct()
    {
        builder.MakeTitle("Greeting");
        builder.MakeString("From Morning to Afternoon");
        builder.MakeItems(new string[] { "Good Morning", "Hello" });

        builder.MakeString("At Night");
        builder.MakeItems(new string[] { "Good Evening", "Good Night" });
        builder.Close();
    }
}
