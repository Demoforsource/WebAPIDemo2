# WebAPIDemo

# Installation Guide

This is a .NET appication. It contains two application and source code.
* Demoapp- .Net application with web api
* Sample-  HTML Page to access web api
* Src/Demoapp- Code for the web api

## This application consists of:

*   Sample pages http://sampleapp/


## Deployment instructions

*   Download all sample code from repository
*   Create new folder Demoapp in  'C:\inetpub\wwwroot\' path
*   Create new folder Sample in  'C:\inetpub\wwwroot\' path
*   Get code from repository and save Demoapp it to 'C:\inetpub\wwwroot\Demoapp' folder (Created in previous step)
*   Get code from repository and save Sample it to 'C:\inetpub\wwwroot\Sample' folder (Created in previous step)
*   Open Internet Information Service (IIS ) Manager
*   Go to Sites and right click on it
*   Select Add Web Site -e.g Demoapp
*   Add Site name and physical path ( e.g C:\inetpub\wwwroot\Demoapp)
*   Add Host name- e.g Dempapp
 * Select Add Web Site -e.g Sampleapp
*   Add Site name and physical path ( e.g C:\inetpub\wwwroot\Sample)
*   Add Host name- e.g Sampleapp
*   Click on Ok button and verify Demoapp and Sampleapp is created in Sites
*   Go to Application Pools and verify Demoapp and  Sampleapp pool are created
*   Right click on apppool anc verify settings
*   It must have .NET Framework Version as v4.0
*   Now add the same host name in host file 
*   
*   [127.0.0.1    Demoapp sampleapp]
*   View sampleapp for demo

## Code Setup

* Download code from respository from Src/Demoapp
* Open in Visual studio 2015


## Output

*   http://Demoapp/api/sample
   ![alt text](https://github.com/Demoforsource/WebAPIDemo2/blob/master/sampleapp1.png)
*   http://Demoapp/api/product
   ![alt text](https://github.com/Demoforsource/WebAPIDemo2/blob/master/sampleapp2.png)
*   http://Demoapp/api/product/1001
   ![alt text](https://github.com/Demoforsource/WebAPIDemo2/blob/master/sampleapp3.png)


I would love to hear your [feedback]
