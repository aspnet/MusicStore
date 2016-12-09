FROM aspnetcorenightly-exp.azurecr.io/aspnetcore-build:1.0.3-msbuild

ENV ASPNETCORE_URLS http://+:5000

COPY src/MusicStore /src/MusicStore/
COPY shared/MusicStoreConfig.cs /shared/
WORKDIR /src/MusicStore

RUN dotnet restore
RUN dotnet build

EXPOSE 5000

ENTRYPOINT ["dotnet", "run"]