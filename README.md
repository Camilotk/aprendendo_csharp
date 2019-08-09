# Apredendo C#
Em certo momento surgiu a necessidade de que eu aprendesse C#, tanto para a utilização com a API de programas 3D que eu já utilizo, quanto para que eu conseguisse ministrar aulas de Unity e para trabalhos da faculdade. Criei esse repositório para armazenar as informações que preciso e exemplos de código durante a transição para a plataforma .NET 

## Instalação no VSCode
1. Baixar a SDK para o sistema operacional desejado. [link para download](https://dotnet.microsoft.com/download)
1. Instalar o VSCode. [link para download](https://code.visualstudio.com/)
1. Instalar as extensões: [C#](https://marketplace.visualstudio.com/items?itemName=ms-vscode.csharp) e [C# extensions](https://marketplace.visualstudio.com/items?itemName=jchannon.csharpextensions)
1. Aqui já está OK para trabalhar, mas podemos intalar algumas ferramentas adicionais. Caso queira apenas começar a programar: *Está Pronto!*
### Ferramentas adicionais
1. (OPCIONAL) Caso, esteja no Windows, instale o [Chocolatey](https://en.wikipedia.org/wiki/NuGet#Chocolatey) e use-o para instalar os pacotes de desenvolvimento. [Instalação](https://chocolatey.org/install#installing-chocolatey) e [Comandos](https://chocolatey.org/docs/commandslist)
1. Instale o node (é necessário para compilar qualquer projeto Web ASP.NET)
```
choco install nodejs
```
3. Faça o update e intale o Yeoman e as depdências necessárias.
```
npm install -g npm
npm i -g yarn gulp 
```

## Utilizando os comandos por Powershell
Quando utilizamos o VSCode para programar em C#, também utilizamos juntamente o Terminal para gerenciar os projetos e depedências. 

| Comando                                                                                | O que faz?        | opc                                   | param.                                                                                                                                                                                                                                                             |
|----------------------------------------------------------------------------------------|-------------------|---------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| dotnet new <opc> -o <nome> <br> dotnet new -l <br> dotnet new <opc> -lang F# -o <name> | Cria novo projeto | <web, react,console, angular, webapi> | -o nome do projeto <br> -l lista de templates <br> -lang <C#, F#, VB>                                                                                                                                                                                              |
| dotnet build                                                                           | Compila o projeto | <nome projeto, nome solução>          | dotnet build -v - verbosidade <br>  dotnet build -o <path> - Caminho do .exe<br> <br> dotnet build --runtime <runtime><br> ex: dotnet build --runtime ubuntu.18.04-x64<br> <br> dotnet build --source <path><br>  ex: dotnet build --source c:\packages\mypackages |
| dotnet run                                                                             | Roda o projeto    |                                       | dotnet run --project ./projects/proj1/proj1.csproj                                                                                                                                                                                                                 |
  
## Powershell
  Por isso, também é útil saber um pouco de como utilizar o Powershell do Windows. Caso utilize Mac ou Linux, pode-se instalar o Powershell e utilizá-lo ou então utilizar o terminal nativo com Bash (que é melhor).
  <br> <br>
  ![Powershell commands](https://github.com/Camilotk/csharp/blob/master/ps-cheatsheet.jpeg "Comandos Powershell")
  [PDF Ver.](https://cdn.comparitech.com/wp-content/uploads/2018/08/Comparitech-Powershell-cheatsheet.pdf)
