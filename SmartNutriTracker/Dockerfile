
# Etapa 1: compilar la aplicación
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build

WORKDIR /src

COPY ["SmartNutriTracker.csproj", "./"]

RUN dotnet restore "SmartNutriTracker.csproj"

COPY . .

RUN dotnet publish "SmartNutriTracker.csproj" \
    -c Release \
    -o /app/publish \
    /p:UseAppHost=false

# Etapa 2: ejecutar la aplicación
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final

WORKDIR /app

COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "SmartNutriTracker.dll"]
