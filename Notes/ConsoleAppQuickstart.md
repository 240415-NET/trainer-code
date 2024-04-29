# C# Console app quickstart guide

To create a console application, we can leverage the ```dotnet new``` command to quickly use the prebuilt console application template that ships with the .NET SDK. We can also leverage options to tailor the behavior of or command. For example, the following command:

```bash
dotnet new console
```

will create a new console application inside of our current directory, with no Main method or associated boilerplate in the Program.cs file. To get the more familiar version of Program.cs seen below, we need to play with an options for the above command.

```csharp
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
```

If we want to generate the above code, we need to add the ```--use-program-main``` option to our command. Additionally, we can make use of ```-o``` to specify an output folder to hold our new project. This can save us from having to manually create and then navigate into a folder before running our ```dotnet new``` command.

```bash
dotnet new console -o OutputDirectory --use-program-main
```

The above command will create a new folder (OutputDirectory in this case) with a dotnet console application inside who's Program.cs contains the Main method and associated code.

[Click here to read more about the ```dotnet new``` command, if you're curious about other options and templates available to us.](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-new)
