#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

# Container we use for final publish
FROM mcr.microsoft.com/dotnet/core/aspnet:6.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Build container
FROM mcr.microsoft.com/dotnet/core/sdk:6.0-buster AS build

# Copy the code into the container
WORKDIR /src
COPY ["src/VyStar.ApiStandards.CUFX/VyStar.ApiStandards.CUFX.csproj", "VyStar.ApiStandards.CUFX/"]

# NuGet restore
RUN dotnet restore "VyStar.ApiStandards.CUFX/VyStar.ApiStandards.CUFX.csproj"
COPY ["src/VyStar.ApiStandards.CUFX/", "VyStar.ApiStandards.CUFX/"]

# Build the API
WORKDIR "VyStar.ApiStandards.CUFX"
RUN dotnet build "VyStar.ApiStandards.CUFX.csproj" -c Release -o /app/build

# Publish it
FROM build AS publish
RUN dotnet publish "VyStar.ApiStandards.CUFX.csproj" -c Release -o /app/publish

# Make the final image for publishing
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "VyStar.ApiStandards.CUFX.dll"]
