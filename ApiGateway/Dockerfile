FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build

ENV APP_HOME /opt/app
RUN mkdir $APP_HOME
WORKDIR $APP_HOME

COPY ApiGateway/*.csproj $APP_HOME/
RUN cd $APP_HOME && dotnet restore

COPY ApiGateway/ $APP_HOME/
RUN cd $APP_HOME && dotnet build

FROM build AS publish
WORKDIR $APP_HOME
RUN cd $APP_HOME && dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS final
WORKDIR /app
ENV ASPNETCORE_URLS=http://+:8099
COPY --from=publish /opt/app/out ./
ENTRYPOINT ["dotnet", "ApiGateway.dll"]