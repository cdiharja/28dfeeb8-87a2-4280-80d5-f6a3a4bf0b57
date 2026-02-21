# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY Solver.sln .
COPY Solver/Solver.csproj Solver/
RUN dotnet restore Solver/Solver.csproj

COPY Solver/ Solver/
RUN dotnet publish Solver/Solver.csproj -c Release -o /app/publish --no-restore
# Runtime stage
FROM mcr.microsoft.com/dotnet/runtime:8.0 AS runtime
WORKDIR /app

COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "Solver.dll"]
