<<<<<<< HEAD
# ---- Build Stage ----
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

# Copy project folder and build from there
COPY ./HPV-ADOLEPAC\ 6.0/ ./HPVADOLEPAC/

WORKDIR /app/HPVADOLEPAC
RUN dotnet publish "HPVADOLEPAC.csproj" -c Release -o /app/out

# ---- Runtime Stage ----
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app/out ./

ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080

=======
# ---- Build Stage ----
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

# Copy project folder and build from there
COPY ./HPV-ADOLEPAC\ 6.0/ ./HPVADOLEPAC/

WORKDIR /app/HPVADOLEPAC
RUN dotnet publish "HPVADOLEPAC.csproj" -c Release -o /app/out

# ---- Runtime Stage ----
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app/out ./

ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080

>>>>>>> 7aa8ae0fecd700af9004e6f058e6b151c8155bd7
ENTRYPOINT ["dotnet", "HPVADOLEPAC.dll"]