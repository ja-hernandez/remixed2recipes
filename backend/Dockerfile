FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["RemixedRecipes/RemixedRecipes.csproj", "RemixedRecipes/"]
RUN dotnet restore "RemixedRecipes/RemixedRecipes.csproj"
COPY . .
WORKDIR "/src/RemixedRecipes"
RUN dotnet build "RemixedRecipes.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RemixedRecipes.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RemixedRecipes.dll"]