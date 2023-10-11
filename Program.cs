using System;

MyApp.Current.Name = "Aplicacao_1";
Console.WriteLine(MyApp.Current.Name);

MyApp.Reset();

Console.WriteLine(MyApp.Current.Name);

MyApp.Current.Name = "Aplicacao_2";
Console.WriteLine(MyApp.Current.Name);

public class MyApp
{
    private MyApp() { }

    public static MyApp Current { get; private set; } = new MyApp();

    public string Name { get; set; }

    public static void Reset()
        => Current = new MyApp();
}