# ---- Build Stage ----
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

# Copy everything and restore
COPY . ./
RUN dotnet publish "HPV-ADOLEPAC 6.0.csproj" -c Release -o out

# ---- Runtime Stage ----
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app

# Copy build from previous stage
COPY --from=build /app/out ./

# Configure ASP.NET Core to listen on port 8080
ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080

ENTRYPOINT ["dotnet", "HPV-ADOLEPAC 6.0.dll"]