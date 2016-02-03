
#CCCD API CLIENT

## Overview

This is a .NET application written in C# designed to demonstrate how to communicate with the 
Claim for Crown Court Defence API from the .NET World.

It is by no means complete; it will generate a claim with minimal information only - it does not add fees or expenses.  The purpose
of this app is to demonstrate communication from a C# application to retreive data from and post data to the CCCD system using the API.



## Development Environment

This was developed on a VirtualBox Windows VM hosted on a Mac. Instructions on how to set up the development environment for a Mac are as follows:


### 1. Install Virtual Box on the host machine

Download and install VirtualBox from https://www.virtualbox.org/wiki/Downloads.


### 2. Download a time-limited image of a Windows VM

Download a time-limited development version of Windows from http://dev.modern.ie/tools/vms/mac/.

* Select:
  * Virtual Machine: IE11 on Win8.1
  * Platform VirtualBox
* Click on "Download .zip".
* Double-click the downloaded zip file to create the file "IE11 - Win8.1.ova"


### 3. Instantiate the Windows VM

* Double-click "IE11 - Win8.1.ova" - this will create a Windows VM in Vitual Box with a state of Powered Off
* With the new VM highlighted in VirtualBox, click start to power it up


### 4. Download Virtual Studio
In the Windows VM, fire up Internet Explorer and download Virtual Studio 2015 Community Edition, accepting.


### 5. Set the locale of the Windows machine to UK.
This is to ensure that the date objects in the Windows application are serialized to the correct format of "dd/mm/yyyy".
* Open Control Panel
* Select Clock, Language and Region
* Select Region
* On the Formats tab, select English (United Kingdom) and ensure the short date format is dd/MM/yyyy
* On the Location tab, select United Kingdom

Apply the settings and restart the virtual machine in order for them to take effect

### 6. Clone this repo

navaigate to directory of your choice and clone repo:
git clone git@github.com:ministryofjustice/adp_api_client.git

### 7. Enable Folder Sharing between the Host and the VM
In order to enable the VM to see this git repo checked out on the Host Mac, go to VirtualBox VM Manager on the Mac, click Settings, and Shared Folders, and add the folder on the host mac that contains this repo. In order for this folder share to persist when restarting VirtualBox you can choose "permanent" and "auto-mount" as options.

On the Windows VM, bring up Windows Explorer, navigate to the Network, and it should show the name of the host machine as a connected computer (You may be prompted to enable network sharing and discovery first). Clicking on the machine will enable you to click through to the ADPAPIClient directory, and the ADPAPIClient Visual Studio project.

Double click the Visual Studio file in order to open the project in Visual Studio.


### 8. Set ADP app running on host
Determine the IP address that the host is exposing to the Windows VM, by executing the command "ifconfig" in the terminal. The entry for vboxnetx (where x is a number) will contain the IP address that the Windows machine can use to contact the host server.

If you cannot see an "inet addr" entry you can try restarting virtualbox (i.e. power off/power on) or got to Settings > Network and set Attached to: Host-only adapter. And then change back to NAT again as you will need an internet connection.

Start the adp rails app to respond on that IP address, e.g.

    rails s -b 192.168.33.1

This will cause the rails app to respond to requests on port 3000 on IP address 192.168.33.1.

### 9. Start Virtual Studio and set the IP address
In Visual Studio, ensure that the hard-coded IP address matches the IP address that your VM can contact your host on (in the example above, 192.168.33.1)

* Navigate to the file HttpClient.cs
* Change the host instance variable to the required IP address

### 10. API Key Authentication

This repository does not contain any API key necessary to authenticate all requests to the ADP API endpoints. To authenticate requests you must create a secrets.config file in the same directory as App.config and place the xml below into it:

    <appSettings>
      <add key="SecretApiKey" value="your-api-key-here" />
    </appSettings>

The API key itself must be obtained from the ADP web application by logging in with your advocate administrator account details and viewing the "Manage chamber" page.
