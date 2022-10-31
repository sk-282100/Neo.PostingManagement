#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["src/API/PostingManagement.Api/PostingManagement.Api.csproj", "src/API/PostingManagement.Api/"]
COPY ["src/Infrastructure/PostingManagement.Infrastructure/PostingManagement.Infrastructure.csproj", "src/Infrastructure/PostingManagement.Infrastructure/"]
COPY ["src/Core/PostingManagement.Application/PostingManagement.Application.csproj", "src/Core/PostingManagement.Application/"]
COPY ["src/Core/PostingManagement.Domain/PostingManagement.Domain.csproj", "src/Core/PostingManagement.Domain/"]
COPY ["src/Infrastructure/PostingManagement.Identity/PostingManagement.Identity.csproj", "src/Infrastructure/PostingManagement.Identity/"]
COPY ["src/Infrastructure/PostingManagement.Persistence/PostingManagement.Persistence.csproj", "src/Infrastructure/PostingManagement.Persistence/"]
RUN dotnet restore "src/API/PostingManagement.Api/PostingManagement.Api.csproj"
COPY . .
WORKDIR "/src/src/API/PostingManagement.Api"
RUN dotnet build "PostingManagement.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PostingManagement.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PostingManagement.Api.dll"]
