FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

RUN dotnet tool install -g Microsoft.Web.LibraryManager.Cli
RUN ln -s ~/.dotnet/tools/libman /usr/local/bin/libman

WORKDIR /src
COPY ["src/Ocean.Labs.Web.Mvc/Ocean.Labs.Web.Mvc.csproj", "src/Ocean.Labs.Web.Mvc/"]
COPY ["src/Ocean.Labs.Web.Core/Ocean.Labs.Web.Core.csproj", "src/Ocean.Labs.Web.Core/"]
COPY ["src/Ocean.Labs.Application/Ocean.Labs.Application.csproj", "src/Ocean.Labs.Application/"]
COPY ["src/Ocean.Labs.Core/Ocean.Labs.Core.csproj", "src/Ocean.Labs.Core/"]
COPY ["src/Ocean.Labs.EntityFrameworkCore/Ocean.Labs.EntityFrameworkCore.csproj", "src/Ocean.Labs.EntityFrameworkCore/"]
WORKDIR "/src/src/Ocean.Labs.Web.Mvc"
RUN dotnet restore 

WORKDIR /src
COPY ["src/Ocean.Labs.Web.Mvc", "src/Ocean.Labs.Web.Mvc"]
COPY ["src/Ocean.Labs.Web.Core", "src/Ocean.Labs.Web.Core"]
COPY ["src/Ocean.Labs.Application", "src/Ocean.Labs.Application"]
COPY ["src/Ocean.Labs.Core", "src/Ocean.Labs.Core"]
COPY ["src/Ocean.Labs.EntityFrameworkCore", "src/Ocean.Labs.EntityFrameworkCore"]
WORKDIR "/src/src/Ocean.Labs.Web.Mvc"
RUN libman restore
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "Ocean.Labs.Web.Mvc.dll"]
