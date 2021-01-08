FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build

ENV APP_HOME /opt/app
RUN mkdir $APP_HOME
WORKDIR $APP_HOME

COPY PolicyService.Api/*.csproj $APP_HOME/PolicyService.Api/
COPY PaymentService.Api/*.csproj $APP_HOME/PaymentService.Api/
COPY PaymentService/*.csproj $APP_HOME/PaymentService/
RUN  cd $APP_HOME/PaymentService && dotnet restore

COPY PolicyService.Api $APP_HOME/PolicyService.Api/
COPY PaymentService.Api $APP_HOME/PaymentService.Api/
COPY PaymentService $APP_HOME/PaymentService/
RUN cd $APP_HOME/PaymentService && dotnet build

FROM build AS publish
WORKDIR $APP_HOME/PaymentService
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS final
WORKDIR /app
ENV ASPNETCORE_URLS=http://+:5070
COPY --from=publish /opt/app/PaymentService/out ./
ENTRYPOINT ["dotnet", "PaymentService.dll"]