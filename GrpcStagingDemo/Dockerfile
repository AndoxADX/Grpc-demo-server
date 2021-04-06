#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["GrpcStagingDemo/GrpcStagingDemo.csproj", "GrpcStagingDemo/"]
RUN dotnet restore "GrpcStagingDemo/GrpcStagingDemo.csproj"
COPY . .
WORKDIR "/src/GrpcStagingDemo"
RUN dotnet build "GrpcStagingDemo.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GrpcStagingDemo.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GrpcStagingDemo.dll"]