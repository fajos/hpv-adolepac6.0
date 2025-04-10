# ---- Build Stage ----
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

# Copy the subfolder into the container
COPY ./HPVADOLEPAC/ ./HPVADOLEPAC/

# Set working directory to the project folder
WORKDIR /app/HPVADOLEPAC

# Build the project
RUN dotnet publish "HPVADOLEPAC.csproj" -c Release -o /app/out

# ---- Runtime Stage ----
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app

# Copy build output
COPY --from=build /app/out ./

# Set environment and port
ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080

ENTRYPOINT ["dotnet", "HPVADOLEPAC.dll"]