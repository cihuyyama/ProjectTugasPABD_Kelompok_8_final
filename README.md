# ProjectTugasPABD_Kelompok_8_final

## If you facing Error Like	'Could not copy the file <your directory>/SqlServerSpatial140.dll because it was not found' or anything like this

It was a bug on nuget Microsoft.SqlServer.Types 14.0.314.76 version and i have solution on it

First go to package manager on 'Tools > NuGet Package Manager > Package Manager Console'

enter these command

### 1. `Uninstall-Package Microsoft.ReportingServices.ReportViewerControl.WebForms -Version 150.1484.0`

try to uninstalling Microsoft.ReportingServices.ReportViewerControl.WebForms so we now can uninstal the nugget package

### 2. `Uninnstall-Package Microsoft.SqlServer.Types -Version 14.0.314.76`

uninstalling the nuget

### 3. 'Clean / ReBuild Project' on 'Build' Menu bar

### 4. `Install-Package Microsoft.ReportingServices.ReportViewerControl.WebForms -Version 150.1484.0`

try to installing the Microsoft.ReportingServices.ReportViewerControl.WebForms again

### 5. `Install-Package Microsoft.SqlServer.Types -Version 14.0.314.76`

try to installing the package again, it might be had installed, just to make sure it was installed.

### 6. 'Clean / ReBuild Project' on 'Build' Menu bar

regenerating stuff that we need before
