FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY conta-corrente/ContaCorrente.csproj.WebApi conta-corrente/
RUN dotnet restore conta-corrente/ContaCorrente.WebApi.csproj
COPY . .
WORKDIR /src/conta-corrente
RUN dotnet build ContaCorrente.csproj.WebApi -c Release -o /app

FROM build AS publish
RUN dotnet publish ContaCorrente.csproj.WebApi -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ContaCorrente.WebApi.dll"]
