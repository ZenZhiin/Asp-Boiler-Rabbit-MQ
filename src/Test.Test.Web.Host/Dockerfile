FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/Test.Test.Web.Host/Test.Test.Web.Host.csproj", "src/Test.Test.Web.Host/"]
COPY ["src/Test.Test.Web.Core/Test.Test.Web.Core.csproj", "src/Test.Test.Web.Core/"]
COPY ["src/Test.Test.Application/Test.Test.Application.csproj", "src/Test.Test.Application/"]
COPY ["src/Test.Test.Core/Test.Test.Core.csproj", "src/Test.Test.Core/"]
COPY ["src/Test.Test.EntityFrameworkCore/Test.Test.EntityFrameworkCore.csproj", "src/Test.Test.EntityFrameworkCore/"]
WORKDIR "/src/src/Test.Test.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/Test.Test.Web.Host", "src/Test.Test.Web.Host"]
COPY ["src/Test.Test.Web.Core", "src/Test.Test.Web.Core"]
COPY ["src/Test.Test.Application", "src/Test.Test.Application"]
COPY ["src/Test.Test.Core", "src/Test.Test.Core"]
COPY ["src/Test.Test.EntityFrameworkCore", "src/Test.Test.EntityFrameworkCore"]
WORKDIR "/src/src/Test.Test.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "Test.Test.Web.Host.dll"]
