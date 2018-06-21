FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY conta-corrente/conta-corrente.csproj conta-corrente/
RUN dotnet restore conta-corrente/conta-corrente.csproj
COPY . .
WORKDIR /src/conta-corrente
RUN dotnet build conta-corrente.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish conta-corrente.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "conta-corrente.dll"]
