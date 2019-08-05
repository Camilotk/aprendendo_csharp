# Csharp

## Instalação no VSCode
1. Baixar a SDK para o sistema operacional desejado. [link para download](https://dotnet.microsoft.com/download)
1. Instalar o VSCode. [link para download](https://code.visualstudio.com/)
1. Instalar as extensões: [C#](https://marketplace.visualstudio.com/items?itemName=ms-vscode.csharp) e [C# extensions](https://marketplace.visualstudio.com/items?itemName=jchannon.csharpextensions)

## Utilizando os comandos por Powershell
Quando utilizamos o VSCode para programar em C#, também utilizamos juntamente o Terminal para gerenciar os projetos e depedências. 
| Comando                                                                                | O que faz?        | opc                                   | param.                                                                                                                                                                                                                                                             |
|----------------------------------------------------------------------------------------|-------------------|---------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| dotnet new <opc> -o <nome> <br> dotnet new -l <br> dotnet new <opc> -lang F# -o <name> | Cria novo projeto | <web, react,console, angular, webapi> | -o nome do projeto <br> -l lista de templates <br> -lang <C#, F#, VB>                                                                                                                                                                                              |
| dotnet build                                                                           | Compila o projeto | <nome projeto, nome solução>          | dotnet build -v - verbosidade <br>  dotnet build -o <path> - Caminho do .exe<br> <br> dotnet build --runtime <runtime><br> ex: dotnet build --runtime ubuntu.18.04-x64<br> <br> dotnet build --source <path><br>  ex: dotnet build --source c:\packages\mypackages |
| dotnet run                                                                             | Roda o projeto    |                                       | dotnet run --project ./projects/proj1/proj1.csproj                                                                                                                                                                                                                 |
## Powershell
  Por isso, também é útil saber um pouco de como utilizar o Powershell do Windows. Caso utilize Mac ou Linux, pode-se instalar o Powershell e utilizá-lo ou então utilizar o terminal nativo com Bash (que é melhor).
  ![Powershell commands](https://github.com/Camilotk/csharp/blob/master/Comparitech-Powershell-cheatsheet-1024x695.jpeg "Comandos Powershell")
  [PDF Ver.](https://cdn.comparitech.com/wp-content/uploads/2018/08/Comparitech-Powershell-cheatsheet.pdf)
