FROM microsoft/dotnet:2.1.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1.2-sdk AS build
WORKDIR /src
COPY QIQO.Business.Companies/QIQO.Business.Companies.csproj QIQO.Business.Companies/
COPY QIQO.Business.Companies.Model/QIQO.Business.Companies.Model.csproj QIQO.Business.Companies.Model/
COPY QIQO.Business.Companies.Data/QIQO.Business.Companies.Data.csproj QIQO.Business.Companies.Data/
COPY QIQO.Business.Core/QIQO.Business.Core.csproj QIQO.Business.Core/
RUN dotnet restore QIQO.Business.Companies/QIQO.Business.Companies.csproj
COPY . .
WORKDIR /src/QIQO.Business.Companies
RUN dotnet build QIQO.Business.Companies.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish QIQO.Business.Companies.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "QIQO.Business.Companies.dll"]
