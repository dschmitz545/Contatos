```bash
docker pull mcr.microsoft.com/mssql/server:2017-latest
```

```bash
docker run --name sqlserver2017 -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=1q2w3e4r@#$" -p 1433:1433 -d mcr.microsoft.com/mssql/server:2017-latest
```

```bash
dotnet run --project ./ControleContatos/ControleContatos.csproj
```