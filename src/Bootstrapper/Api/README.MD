dotnet dev-certs https --trust
dotnet run --project src/Bootstrapper/Api
dotnet run --launch-profile https
dotnet run --project src/Bootstrapper/Api --launch-profile https