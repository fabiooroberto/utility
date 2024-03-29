# Pacote de funcionalidades uteis para o desenvolvimento

## GITHUB PACKAGE

URL do local dos pacotes do github

- https://nuget.pkg.github.com
- https://nuget.pkg.github.com/{NomeOrganizacao}/index.json
- https://nuget.pkg.github.com/fabiooroberto/index.json


## LISTA PACOTES

```powershell
dotnet nuget list source
```

## Build
```powershell
dotnet build -c Release
```

## Pack
```powershell
dotnet pack -c Release
```

## PUBLICAR PACOTE

Para publicar o pacote, precisamos de um secret para fazer o envio do pacote para o nosso github.

Como o pacote e o codigo estão na mesma organização do github, basta usar secrets.GITHUB_TOKEN.

Pois, o próprio github já cria automaticamente essa váriável, não sendo necessário a sua criação e configuração.

Para fazer o publicação, utilize.

```
dotnet nuget push "utility/bin/Release/*.nupkg" -k ${{ secrets.GITHUB_TOKEN }} -s https://nuget.pkg.github.com/fabiooroberto/index.json
```
