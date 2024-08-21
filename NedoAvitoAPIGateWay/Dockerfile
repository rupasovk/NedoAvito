#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["NedoAvito.APIGateWay/NedoAvito.APIGateWay.csproj", "NedoAvito.APIGateWay/"]
RUN dotnet restore "NedoAvito.APIGateWay/NedoAvito.APIGateWay.csproj"
COPY . .
WORKDIR "/src/NedoAvito.APIGateWay"
RUN dotnet build "NedoAvito.APIGateWay.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "NedoAvito.APIGateWay.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NedoAvito.APIGateWay.dll"]