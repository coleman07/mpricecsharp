        string name = typeof(Program).Namespace ?? "None!";
        Console.WriteLine("Hello, C#!");
        Console.WriteLine($"Namespace: {name}");
        throw new Exception();
