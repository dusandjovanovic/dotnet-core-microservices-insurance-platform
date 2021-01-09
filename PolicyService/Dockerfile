FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build

ENV APP_HOME /opt/app
RUN mkdir $APP_HOME
WORKDIR $APP_HOME

COPY PricingService.Api/*.csproj $APP_HOME/PricingService.Api/
COPY PolicyService.Api/*.csproj $APP_HOME/PolicyService.Api/
COPY PolicyService/*.csproj $APP_HOME/PolicyService/
RUN cd $APP_HOME/PolicyService && dotnet restore --disable-parallel

COPY PricingService.Api $APP_HOME/PricingService.Api/
COPY PolicyService.Api $APP_HOME/PolicyService.Api/
COPY PolicyService $APP_HOME/PolicyService/
RUN cd PolicyService && dotnet build

FROM build AS publish
WORKDIR $APP_HOME/PolicyService
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS final
WORKDIR /app
ENV ASPNETCORE_URLS=http://+:5050
COPY --from=publish /opt/app/PolicyService/out ./
ENTRYPOINT ["dotnet", "PolicyService.dll"]