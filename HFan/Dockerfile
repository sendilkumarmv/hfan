#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 81

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["HFan.Web.Application/HFan.Web.Application.csproj", "HFan.Web.Application/"]
RUN dotnet restore "HFan.Web.Application/HFan.Web.Application.csproj"
COPY . .
WORKDIR "/src/HFan.Web.Application"
RUN dotnet build "HFan.Web.Application.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HFan.Web.Application.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HFan.Web.Application.dll"]