FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/Ocean.Labs.Web.Host/Ocean.Labs.Web.Host.csproj", "src/Ocean.Labs.Web.Host/"]
COPY ["src/Ocean.Labs.Web.Core/Ocean.Labs.Web.Core.csproj", "src/Ocean.Labs.Web.Core/"]
COPY ["src/Ocean.Labs.Application/Ocean.Labs.Application.csproj", "src/Ocean.Labs.Application/"]
COPY ["src/Ocean.Labs.Core/Ocean.Labs.Core.csproj", "src/Ocean.Labs.Core/"]
COPY ["src/Ocean.Labs.EntityFrameworkCore/Ocean.Labs.EntityFrameworkCore.csproj", "src/Ocean.Labs.EntityFrameworkCore/"]
WORKDIR "/src/src/Ocean.Labs.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/Ocean.Labs.Web.Host", "src/Ocean.Labs.Web.Host"]
COPY ["src/Ocean.Labs.Web.Core", "src/Ocean.Labs.Web.Core"]
COPY ["src/Ocean.Labs.Application", "src/Ocean.Labs.Application"]
COPY ["src/Ocean.Labs.Core", "src/Ocean.Labs.Core"]
COPY ["src/Ocean.Labs.EntityFrameworkCore", "src/Ocean.Labs.EntityFrameworkCore"]
WORKDIR "/src/src/Ocean.Labs.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "Ocean.Labs.Web.Host.dll"]
