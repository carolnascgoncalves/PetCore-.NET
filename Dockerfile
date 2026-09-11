FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

COPY ["PetCore/PetCore.Api/PetCore.Api.csproj", "PetCore/PetCore.Api/"]
COPY ["PetCore/PetCore.Application/PetCore.Application.csproj", "PetCore/PetCore.Application/"]
COPY ["PetCore/PetCore.Domain/PetCore.Domain.csproj", "PetCore/PetCore.Domain/"]
COPY ["PetCore/PetCore.Infrastructure/PetCore.Infrastructure.csproj", "PetCore/PetCore.Infrastructure/"]
RUN dotnet restore "PetCore/PetCore.Api/PetCore.Api.csproj"
COPY PetCore/ PetCore/
WORKDIR /src/PetCore/PetCore.Api
RUN dotnet publish "PetCore.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app
ENV ASPNETCORE_URLS=http://+:8080 \
    ASPNETCORE_FORWARDEDHEADERS_ENABLED=true
EXPOSE 8080
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "PetCore.Api.dll"]