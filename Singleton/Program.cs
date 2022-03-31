Console.WriteLine($"Start: {Singleton.Singleton.GetInstance().Count}");

Singleton.Singleton.GetInstance().Increase();
Console.WriteLine($"First: {Singleton.Singleton.GetInstance().Count}");

Singleton.Singleton.GetInstance().Increase();
Console.WriteLine($"Second: {Singleton.Singleton.GetInstance().Count}");

Singleton.Singleton.GetInstance().Increase();
Console.WriteLine($"Third: {Singleton.Singleton.GetInstance().Count}");