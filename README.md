# WCF Self-Hosted Rest Service with CORS

A simple Windows WCF service Self-hosted with CORS enabled. 

For debug this project ( > Windows 7 ) :

Configuring namespace reservations, InstallUtil, Firewall Exception, Start Service.

Command-line :

netsh http add urlacl url=http://localhost:8888/Rest user=*
C:\Windows\Microsoft.NET\Framework\v4.0.30319\InstallUtil -i C:\Rest\RestWinService.exe
netsh advfirewall firewall add rule name="RestApi" dir=in action=allow program="C:\Rest\RestWinService.exe" enable=yes
net start RestApi

