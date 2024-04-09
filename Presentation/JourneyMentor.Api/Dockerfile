#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Presentation/JourneyMentor.Api/JourneyMentor.Api.csproj", "Presentation/JourneyMentor.Api/"]
COPY ["Core/JourneyMentor.Mapper/JourneyMentor.Mapper.csproj", "Core/JourneyMentor.Mapper/"]
COPY ["Core/JourneyMentor.Application/JourneyMentor.Application.csproj", "Core/JourneyMentor.Application/"]
COPY ["Core/JourneyMentor.Domain/JourneyMentor.Domain.csproj", "Core/JourneyMentor.Domain/"]
COPY ["Infrastucture/JourneyMentor.Infrastructure/JourneyMentor.Infrastructure.csproj", "Infrastucture/JourneyMentor.Infrastructure/"]
COPY ["Infrastucture/JourneyMentor.Persistence/JourneyMentor.Persistence.csproj", "Infrastucture/JourneyMentor.Persistence/"]
RUN dotnet restore "./Presentation/JourneyMentor.Api/./JourneyMentor.Api.csproj"
COPY . .
WORKDIR "/src/Presentation/JourneyMentor.Api"
RUN dotnet build "./JourneyMentor.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./JourneyMentor.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "JourneyMentor.Api.dll"]