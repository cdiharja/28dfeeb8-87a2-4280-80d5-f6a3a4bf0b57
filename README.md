# K - Longest Increasing Subsequence

Finds the longest contiguous increasing subsequence from a space-separated list of integers.

## Requirements

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download)
- Or [Docker](https://www.docker.com/)

## Run

### With .NET

```bash
dotnet run --project Solver
```

Then enter a space-separated list of integers:
```
6 1 5 9 2
```

Output:
```
1 5 9
```

### With Docker

```bash
docker build -t solver-app .
echo "6 1 5 9 2" | docker run -i solver-app
```

## Test

```bash
dotnet test
```

### With coverage

```bash
dotnet test --collect:"XPlat Code Coverage"
reportgenerator -reports:"**/coverage.cobertura.xml" -targetdir:"coveragereport" -reporttypes:Html
open coveragereport/index.html
```
