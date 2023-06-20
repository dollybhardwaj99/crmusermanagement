FROM mcr.microsoft.com/dotnet/aspnet:5.0-focal AS base
WORKDIR /app
EXPOSE 4000

ENV ASPNETCORE_URLS=http://+:4000

# Creates a non-root user with an explicit UID and adds permission to access the /app folder
# For more info, please refer to https://aka.ms/vscode-docker-dotnet-configure-containers
RUN adduser -u 5678 --disabled-password --gecos "" appuser && chown -R appuser /app
USER appuser

FROM mcr.microsoft.com/dotnet/sdk:5.0-focal AS build
WORKDIR /src
COPY ["./Services/CRM.Services.LeadManagement.csproj", "Services/"]
RUN dotnet restore "Services/CRM.Services.LeadManagement.csproj"
COPY . .
WORKDIR "/src/Services"
RUN dotnet build "CRM.Services.LeadManagement.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CRM.Services.LeadManagement.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CRM.Services.LeadManagement.dll"]
