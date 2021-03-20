#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Softplan.API.csproj", "Softplan.API/"]
RUN dotnet restore "Softplan.API/Softplan.API.csproj"
COPY . . 
WORKDIR "/src/Softplan.API"
RUN dotnet build "Softplan.API.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Softplan.API.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Softplan.API.dll"]