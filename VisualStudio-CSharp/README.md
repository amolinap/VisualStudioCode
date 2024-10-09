## Visual Studio Code

### Configuración C# en Visual Studio Code en Mac

Free. Cross-platform. Open source.
Download .NET

For macOS

https://dotnet.microsoft.com/en-us/download

https://download.visualstudio.microsoft.com/download/pr/d6b3fe61-3c0e-45da-9e37-cef64d4fd3eb/28d536e0ecfbb330ab49454a5e3962f6/dotnet-sdk-8.0.403-osx-x64.pkg

https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-8.0.403-macos-x64-installer

### Setting Up a .NET Project on macOS 

[Setting Up a .NET Project on macOS](https://dev.to/rusydy/setting-up-a-net-project-on-macos-590m)

Step 1: Verify .NET Core Installation

```
dotnet --version
8.0.403
```

Step 2: Create a New Web API Project 

```
dotnet new webapi -n RestApi

Welcome to .NET 8.0!
---------------------
SDK Version: 8.0.403

Telemetry
---------
The .NET tools collect usage data in order to help us improve your experience. It is collected by Microsoft and shared with the community. You can opt-out of telemetry by setting the DOTNET_CLI_TELEMETRY_OPTOUT environment variable to '1' or 'true' using your favorite shell.

Read more about .NET CLI Tools telemetry: https://aka.ms/dotnet-cli-telemetry

----------------
Installed an ASP.NET Core HTTPS development certificate.
To trust the certificate, run 'dotnet dev-certs https --trust'
Learn about HTTPS: https://aka.ms/dotnet-https

----------------
Write your first app: https://aka.ms/dotnet-hello-world
Find out what's new: https://aka.ms/dotnet-whats-new
Explore documentation: https://aka.ms/dotnet-docs
Report issues and find source on GitHub: https://github.com/dotnet/core
Use 'dotnet --help' to see available commands or visit: https://aka.ms/dotnet-cli
--------------------------------------------------------------------------------------
An issue was encountered verifying workloads. For more information, run "dotnet workload update".
The template "ASP.NET Core Web API" was created successfully.

Processing post-creation actions...
Restoring /Users/dav-29/MisDocumentos/GitRepositorios/VisualStudioCode/VisualStudioC#/00_Project-WebApi/RestApi/RestApi.csproj:
  Determining projects to restore...
  Restored /Users/dav-29/MisDocumentos/GitRepositorios/VisualStudioCode/VisualStudioC#/00_Project-WebApi/RestApi/RestApi.csproj (in 3.76 sec).
Restore succeeded.
```

Step 3: Install Required Dependencies 

Code Generation 

```
dotnet tool install -g dotnet-aspnet-codegenerator
Tools directory '/Users/dav-29/.dotnet/tools' is not currently on the PATH environment variable.
If you are using zsh, you can add it to your profile by running the following command:

cat << \EOF >> ~/.zprofile
# Add .NET Core SDK tools
export PATH="$PATH:/Users/dav-29/.dotnet/tools"
EOF

And run `zsh -l` to make it available for current session.

You can only add it to the current session by running the following command:

export PATH="$PATH:/Users/dav-29/.dotnet/tools"

You can invoke the tool using the following command: dotnet-aspnet-codegenerator
Tool 'dotnet-aspnet-codegenerator' (version '8.0.6') was successfully installed.
```

```
cd RestApi
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
```

Entity Framework 

```
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
```

Step 4: Create a Model 

```
using System;

namespace RestApi.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // Add other properties as needed
    }
}
```

Step 5: Generate a Controller 

```
dotnet aspnet-codegenerator controller -name RecipesController -async -api -m Recipe -dc ApplicationDbContext

Building project ...
Finding the generator 'controller'...
Running the generator 'controller'...
No database provider found. Using 'SqlServer' by default for new DbContext creation!
Using 'SQL Server' by default!

Minimal hosting scenario!
Generating a new DbContext class 'ApplicationDbContext'
Attempting to compile the application in memory with the added DbContext.
Attempting to figure out the EntityFramework metadata for the model and DbContext: 'Recipe'

Using database provider 'Microsoft.EntityFrameworkCore.SqlServer'!

Added DbContext : '/Data/ApplicationDbContext.cs'
Added Controller : '/RecipesController.cs'.
RunTime 00:00:10.45
```

### Videos

https://www.youtube.com/watch?v=0w5JXGx2bFE

NET on MacOS - Creating ASP.NET Core MVC App with VS Code
https://www.youtube.com/watch?v=HIfhAqaHq2A