using Autofac;
using Dnj.Colab.Training.IoCandDI;

static class Program
{
    private static IContainer Root()
    {
        ContainerBuilder builder = new();

        builder.RegisterType<MyService>();
        builder.RegisterType<MyServiceOther>().As<IMyServiceTwo>();
        builder.RegisterType<MyRepository>().As<IMyRepository>();

        return builder.Build();
    }

    public static void Main()
    {
        Root().Resolve<MyService>().Run();
        Console.ReadKey();
    }
}