# escape=`
 
FROM microsoft/aspnet:4.7.1-windowsservercore-ltsc2016
 
#Set the shell and indicate we want to use powershell
SHELL ["powershell", "-Command", "$ErrorActionPreference = 'Stop'; $ProgressPreference ='SilentlyContinue';"]
 
# We can copy the published content into the wwwroot folder.
ADD ./bin/release/publish ./inetpub/wwwroot
 
# Lets execute a powershell commands to install choco and nuget, then we can install the WebConfigTransformRunner, so that we can apply configuration transformations dynamically.


RUN Set-ExecutionPolicy Bypass; iex ((New-Object System.Net.WebClient).DownloadString('https://chocolatey.org/install.ps1'));` 
	choco install nuget.commandline --allow-empty-checksums -y;`
	   nuget install WebConfigTransformRunner -Version 1.0.0.1
 
# Set the entry point,
ENTRYPOINT C:\ServiceMonitor.exe w3svc