# GFI-PST-Bulk-Import-with-Yubico

Bulk PST file import into GFI Archiver

1. Why this tool?

The challenge in GFI Archiver is to automate the import of PST files located on a centralized storage. While 
GFI provides tools to import PST files, in our environment they are not sufficient. A couple of challenges we 
came across with the existing/inbuilt options:

GFI Archive Assistant:

Client/Outlook based import. The user needs to have opened Microsoft Outlook to import PST files. The Import 
process for a large amount of PST files is slow and affects the Users Microsoft Outlook performance. Also there 
is no simple way to import PST files only, the Archive Assistant imports all user mounted mailboxes/accounts/pst files.

GFI Import/Export Tool

This tools needs to be executed manually on the server. While you can select multiple PST files, you can only 
assign a single owner, means for a large amount of users you need to import the users pst files once by once. 
Also there is no automation or a commandline utility available to script the import process.

GFI Mass Exporter Tool

This is a commandline tool, which provides capabilities to automate the import process of PST files. However it 
depends on a CSV File, which needs to be generated manually. Also the tools is limited where PST files can be located... 
all PST files needs to be located into a single folder otherwise it's not able to import and an error message occurs

2. What does the tool better?

The tools use the GFI Mass Exporter Tool, however with a lot of automation around, to help import PST files automatically. It provides
scheduling, alerting, monitoring on import jobs. It provides a simple to use GUI and in case you want to secure the usage of the tool a 
2 factor authentication (powered by Yubikey).

3. Features overview

- Easy to use GUI
  - Configuration
  - Schedule
  - Execute Jobs
- Import PST files
  - Easy to use configuration
  - Path mode and Directory mode
  - Import via Pickup Folder or HTTP connection
  - Schedule Import Jobs
- Monitoring
  - Service health status (recommend to monitor GFI Archiver Services)
  - Host performance like CPU usage, Memory usage, Network bandwidth utilization
  - Eventlog monitoring
  - GFI Archiver Import Service Queue monitor
  - Import Job statistics
- Alerting via E-Mail
  - On service outages
  - Import job events
  - High CPU usage
  - Queue Monitor events
- 2 factor authentication
  - Prevent unauthorized access
  - Easy to use via Yubikey OTP/Yubico Cloud

4. How to start

- Clone/Branch the Github repo or Download the sources
- Load the project with Visual studio 2015 or higher
- Compile the project and start the "GFI PST Bulk Import.exe"

5. Features not fully implemented

- Directory import (Use LDAP/Active Directory to create path structure to import PST files)
- HTTP mode (Make use of the Web API of GFI Archiver to import PST Files)
- Scheduler (Create schedules work, however the jobs won't be executed)

6. Why publish to public Github repo

Because of lack of time and other projects involved it's difficult to develop and maintain all the features 
and functions. So I hope that with a strong community, additional features, ideas or bugfixes are implemented much faster.

  



