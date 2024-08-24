FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src
COPY ["src/MonkeyAndRiver.Web.Host/MonkeyAndRiver.Web.Host.csproj", "src/MonkeyAndRiver.Web.Host/"]
COPY ["src/MonkeyAndRiver.Web.Core/MonkeyAndRiver.Web.Core.csproj", "src/MonkeyAndRiver.Web.Core/"]
COPY ["src/MonkeyAndRiver.Application/MonkeyAndRiver.Application.csproj", "src/MonkeyAndRiver.Application/"]
COPY ["src/MonkeyAndRiver.Core/MonkeyAndRiver.Core.csproj", "src/MonkeyAndRiver.Core/"]
COPY ["src/MonkeyAndRiver.EntityFrameworkCore/MonkeyAndRiver.EntityFrameworkCore.csproj", "src/MonkeyAndRiver.EntityFrameworkCore/"]
WORKDIR "/src/src/MonkeyAndRiver.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/MonkeyAndRiver.Web.Host", "src/MonkeyAndRiver.Web.Host"]
COPY ["src/MonkeyAndRiver.Web.Core", "src/MonkeyAndRiver.Web.Core"]
COPY ["src/MonkeyAndRiver.Application", "src/MonkeyAndRiver.Application"]
COPY ["src/MonkeyAndRiver.Core", "src/MonkeyAndRiver.Core"]
COPY ["src/MonkeyAndRiver.EntityFrameworkCore", "src/MonkeyAndRiver.EntityFrameworkCore"]
WORKDIR "/src/src/MonkeyAndRiver.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "MonkeyAndRiver.Web.Host.dll"]
