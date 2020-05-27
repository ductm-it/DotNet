FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["uit-project-framework/uit-project-framework.csproj", "uit-project-framework/"]
RUN dotnet restore "uit-project-framework/uit-project-framework.csproj"
COPY . .
WORKDIR "/src/uit-project-framework"
RUN dotnet build "uit-project-framework.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "uit-project-framework.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "uit-project-framework.dll"]