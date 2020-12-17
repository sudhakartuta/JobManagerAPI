FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /App

# Copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1

#COPY JobManagerAPI/bin/Release/netcoreapp3.1/publish App/

WORKDIR /App


RUN apt-get update
RUN apt-get install iputils-ping -y

COPY --from=build-env /App/out .
COPY *.sql /App/sql/

EXPOSE 80

ENTRYPOINT ["dotnet","JobManagerAPI.dll"]
#CMD /bin/bash ./entrypoint.sh


