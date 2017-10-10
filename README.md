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
