# SQL Connection Tester
This console app helps to verify SQL connection strings and test connectivity on any kind of SQL Server.

Very usefull to troubleshooting connection issues or to configure environments before apps are delivered.

![image](https://user-images.githubusercontent.com/17268332/112715600-719f8e80-8ee1-11eb-9050-8dbe4d9a7b88.png)

# Publishing binaries

To publish to a linux target :
```
dotnet publish -r linux-x64 -p:PublishSingleFile=true 
```
To publish to a windows target :
```
dotnet publish -r win10-x64 -p:PublishSingleFile=true
```
