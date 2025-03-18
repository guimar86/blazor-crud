# Use the official .NET SDK image to build the app
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
EXPOSE 8080
ENV ASPNETCORE_ENVIRONMENT=Development

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy only the .csproj file
COPY BlazorCrud/BlazorCrud.csproj BlazorCrud/
WORKDIR /src/BlazorCrud
RUN dotnet restore

# Copy the rest of the application source code
COPY . .
RUN dotnet publish -c Release -o /app

# Use the runtime image to run the app
FROM base as final
WORKDIR /app
COPY --from=build /app .

# Start the application
ENTRYPOINT ["dotnet", "BlazorCrud.dll"]