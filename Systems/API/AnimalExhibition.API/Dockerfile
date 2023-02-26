#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Systems/API/AnimalExhibition.API/AnimalExhibition.API.csproj", "Systems/API/AnimalExhibition.API/"]
COPY ["Services/AnimalExhibition.Services.Settings/AnimalExhibition.Services.Settings.csproj", "Services/AnimalExhibition.Services.Settings/"]
COPY ["Shared/AnimalExhibition.Settings/AnimalExhibition.Settings.csproj", "Shared/AnimalExhibition.Settings/"]
COPY ["Shared/AnimalExhibition.Common/AnimalExhibition.Common.csproj", "Shared/AnimalExhibition.Common/"]
COPY ["Systems/API/AnimalExhibition.Settings/AnimalExhibition.API.Settings.csproj", "Systems/API/AnimalExhibition.Settings/"]
RUN dotnet restore "Systems/API/AnimalExhibition.API/AnimalExhibition.API.csproj"
COPY . .
WORKDIR "/src/Systems/API/AnimalExhibition.API"
RUN dotnet build "AnimalExhibition.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AnimalExhibition.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AnimalExhibition.API.dll"]