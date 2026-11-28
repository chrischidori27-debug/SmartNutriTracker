@'
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build

WORKDIR /src

COPY ["SmartNutriTracker.csproj", "./"]

RUN dotnet restore "SmartNutriTracker.csproj"

COPY . .

RUN dotnet publish "SmartNutriTracker.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final

WORKDIR /app

COPY --from=build /app/publish .

ENTRYPOINT ["sh", "-c", "dotnet SmartNutriTracker.dll --urls http://0.0.0.0:${PORT:-8080}"]
'@ | Set-Content ".\SmartNutriTracker\Dockerfile" -Encoding utf8