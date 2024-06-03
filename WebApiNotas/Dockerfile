#Usa la imagen base de .NET SDK para construir la aplicación
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

#Copia los archivos de proyecto y restaura las dependencias
COPY WebApiNotas.csproj ./

RUN dotnet restore

#Copia el resto de los archivos y construye la aplicación
COPY . ./
RUN dotnet publish -c Release -o out

#Usa la imagen base de .NET Runtime para ejecutar la aplicación
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

COPY --from=build /app/out .

#Expone el puerto en el que la aplicación escuchará
EXPOSE 80

#Define el comando de entrada para ejecutar la aplicación
ENTRYPOINT ["dotnet", "WebApiNotas.dll"]