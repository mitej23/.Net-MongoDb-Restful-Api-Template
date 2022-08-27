# .Net-MongoDb-Restful-Api-Template

# Note 1: 

Due to security purpose I have removed the appsettings.json file from the project. Don't forget to add that.

Add this code in your appsettings.json file

{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "DatabaseSettings": {
    "ConnectionString": "<your mongodb connection string>",
    "DatabaseName": "SuggestMe"
  },
  "AllowedHosts": "*"
}

# Note 2
Your IP address might change depending upon your network provider. So keep a note of your ip address whitelisted in the mongodb atlas.



