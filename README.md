# Initialer Setup

- `dotnet new xunit -o RailwayDemo`
- `cd RailwayDemo`
- `dotnet restore`
- VSCode aufmachen: `code .`
- Projekt initialisieren (klick 'Yes'): Erstellt `.vscode` Ordner
- Abhaengigkeiten installieren:
    - `dotnet add package FluentAssertions`
    - `dotnet add package NSubstitute`
    - `dotnet add package CSharpFunctionalExtensions`
- danach entweder `dotnet restore` via cli oder in VSCode auf 'Ja' klicken
- `Tests` Ordner in VSCode anlegen
- **Test Task** in `.vscode/tasks.json` anlegen:
``` json
{
    "taskName": "test",
    "args": [],
    "isTestCommand": true,
    "showOutput": "always",
    "problemMatcher": "$msCompile"
}
```
- der **Test Task** kann in VSCode mittels `Ctrl+Shift+P` aufgerufen werden (`Tasks: Run Test Task`). Entspricht dem cli Aufruf `dotnet test`.


## Version info

```
$ dotnet --info
.NET Command Line Tools (2.0.0)

Product Information:
 Version:            2.0.0
 Commit SHA-1 hash:  cdcd1928c9

Runtime Environment:
 OS Name:     ubuntu
 OS Version:  16.04
 OS Platform: Linux
 RID:         ubuntu.16.04-x64
 Base Path:   /usr/share/dotnet/sdk/2.0.0/

Microsoft .NET Core Shared Framework Host

  Version  : 2.0.0
  Build    : e8b8861ac7faf042c87a5c2f9f2d04c98b69f28d
```
