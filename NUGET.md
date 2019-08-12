# .NET Core Package Manager .NuGET
Com frequência, durante o desenvolvimento das nossas aplicações, precisamos instalar pacotes de terceiros para realizar as mais diversas tarefas, como acesso a bancos de dados, validações, etc.
<br><br>
Antes do NuGet esse procedimento era feito de forma manual, ou seja, precisávamos realizar nos sites dos desenvolvedores o download das bibliotecas e incluí-las em nossos projetos. Quando uma nova versão era lançada, era preciso baixá-la novamente e substituir em todos os locais em que ela estivesse sendo usada.
<br><br>
Com o NuGet esse procedimento é simplificado. Todas as bibliotecas ficam centralizadas no repositório nuget.org e por meio de uma ferramenta integrada ao Visual Studio é possível instalar, atualizar e remover os pacotes de forma bastante prática.
<br><br>
Quando instalamos um pacote em nossa aplicação o NuGet o registra no arquivo packages.config, semelhante ao pom.xml do Maven, composer.json do Composer e package.json do NPM. A partir desse arquivo podemos reinstalar com facilidade todos os pacotes posteriormente.

## Pré-requesitos
- O SDK do .NET Core, que fornece a ferramenta de linha de comando dotnet. [Baixar Aqui](https://dotnet.microsoft.com/download)

## Commandos e Utilização
### Instalando Pacote
1. Entrar na pasta do _projeto_ em que o pacote será instalado.
2. Dentro da pasta, utilizar o CLI do .NET para instalar o pacote desejado.
```
dotnet add package <nome do pacote> -v=1.0.1
dotnet add <projeto> package <nome do pacote> --version=1.0.1
```
3. Após a conclusão do comando, abra o arquivo *.csproj* para ver a referência adicionada.
```XML
<ItemGroup>
<PackageReference Include="Nome do Pacote" Version="1.0.1" />
</ItemGroup>
```
4. Ao executar o comando **dotnet run** ou **dotnet build**, automaticamente, em primeiro lugar será checado o arquivo .csproj e as depedências serão atualizadas.
### Atualizando Pacote
- Para fazer o Update de um pacote basta rodar o comando **dotnet add** com o nome do pacote sem a _flag_ --version (-v) ou especificando para qual versão quer fazer o upograde/downgrade
### Removendo Pacote
1. Entrar na pasta do _projeto_ em que o pacote será removido.
2. Dentro da pasta, utilizar o CLI do .NET para remover o pacote desejado.
```
dotnet remove package <nome do pacote>
dotnet remove <projeto> package <nome do pacote>
```
3. Após a conclusão do comando, abra o arquivo *.csproj* para ver a referência foi removida.
4. Ao executar o comando **dotnet run** ou **dotnet build**, automaticamente, em primeiro lugar será checado o arquivo .csproj e as depedências serão atualizadas.
