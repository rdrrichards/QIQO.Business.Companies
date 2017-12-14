FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY *.sln ./
COPY QIQO.Business.Companies/QIQO.Business.Companies.csproj QIQO.Business.Companies/
COPY QIQO.Business.Companies.Model/QIQO.Business.Companies.Model.csproj QIQO.Business.Companies.Model/
COPY QIQO.Business.Companies.Data/QIQO.Business.Companies.Data.csproj QIQO.Business.Companies.Data/
COPY QIQO.Business.Core/QIQO.Business.Core.csproj QIQO.Business.Core/
RUN dotnet restore
COPY . .
WORKDIR /src/QIQO.Business.Companies
RUN dotnet build -c Release -o /app

FROM build AS publish
RUN dotnet publish -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "QIQO.Business.Companies.dll"]
