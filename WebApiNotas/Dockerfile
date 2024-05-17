FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copiar archivos de proyecto y restaurar dependencias
COPY *.csproj .
COPY *.sln .
RUN dotnet restore

# Compilar la aplicación
COPY . .
RUN dotnet build

# Establecer la imagen de trabajo como la imagen base ASP.NET Core
FROM mcr.microsoft.com/dotnet/aspnetcore:8.0

WORKDIR /app

# Copiar archivos binarios y el contenido web publicado
COPY --from=build /app/bin .
COPY --from=build /app/publish .

# Exponer el puerto 3000
EXPOSE 3000

# Definir el punto de entrada para ejecutar la aplicación
ENTRYPOINT ["dotnet", "WebApiNotass.dll"]
