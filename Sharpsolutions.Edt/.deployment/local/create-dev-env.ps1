function New-Development-Site {
           
  <#
  .SYNOPSIS
  Creates a new website in IIS that is accessible onl by ssl
  .DESCRIPTION
  Creates a new website in IIS that is accessible onl by ssl
  .EXAMPLE
  Give an example of how to use it
  .EXAMPLE
  Give another example of how to use it
  .PARAMETER computername
  The computer name to query. Just one.
  .PARAMETER logname
  The name of a file to write failed computer names to. Defaults to errors.txt.
  #>
   param ($iisPort, $directoryPath)
   
   Import-Module WebAdministration

    $iisAppPoolName = "localhost$iisPort"
    $iisAppPoolDotNetVersion = "v4.0"
    $iisAppName = "localhost$iisPort"

    #navigate to the app pools root
    cd IIS:\AppPools\

    #create the directory
    if(!(Test-Path $directoryPath)){
    New-Item $directoryPath -ItemType directory
}

    #check if the app pool exists
    if ((Test-Path $iisAppPoolName -pathType container))
    {
    Remove-Item $iisAppPoolName
}

#create the app pool
$appPool = New-Item $iisAppPoolName
$appPool | Set-ItemProperty -Name "managedRuntimeVersion" -Value $iisAppPoolDotNetVersion

#navigate to the sites root
cd IIS:\Sites\

#check if the site exists
if (Test-Path $iisAppName -pathType container)
{
    Remove-Item $iisAppName
}

#create the site
$iisApp = New-Item $iisAppName -bindings @{protocol="https";bindingInformation=":"+ $iisPort +":localhost"} -physicalPath $directoryPath
$iisApp | Set-ItemProperty -Name "applicationPool" -Value $iisAppPoolName

$certifcate = (Get-ChildItem -Path Cert:\LocalMachine\My | Where-Object {$_.Subject -match "CN=localhost"});

$thumbprint = $certifcate.Thumbprint.ToString();


$sslBindingPath = "IIS:\SslBindings\0.0.0.0!$iisPort"

if(Test-Path $sslBindingPath){
    Remove-Item $sslBindingPath
}

new-item -Path $sslBindingPath  -Value $certifcate

              

}

# Get the ID and security principal of the current user account
 $myWindowsID=[System.Security.Principal.WindowsIdentity]::GetCurrent()
 $myWindowsPrincipal=new-object System.Security.Principal.WindowsPrincipal($myWindowsID)
  
 # Get the security principal for the Administrator role
 $adminRole=[System.Security.Principal.WindowsBuiltInRole]::Administrator
  
 # Check to see if we are currently running "as Administrator"
 if ($myWindowsPrincipal.IsInRole($adminRole))
    {
    # We are running "as Administrator" - so change the title and background color to indicate this
    $Host.UI.RawUI.WindowTitle = $myInvocation.MyCommand.Definition + "(Elevated)"
    $Host.UI.RawUI.BackgroundColor = "DarkBlue"
    clear-host
    }
 else
    {
    # We are not running "as Administrator" - so relaunch as administrator
    
    # Create a new process object that starts PowerShell
    $newProcess = new-object System.Diagnostics.ProcessStartInfo "PowerShell";
    
    # Specify the current script path and name as a parameter
    $newProcess.Arguments = $myInvocation.MyCommand.Definition;
    
    # Indicate that the process should be elevated
    $newProcess.Verb = "runas";
    
    # Start the new process
    [System.Diagnostics.Process]::Start($newProcess);
    
    # Exit from the current, unelevated, process
    exit
    }

New-Development-Site -iisPort 44300 -directoryPath "$PsScriptRoot\..\..\Sharpsolutions.Edt.Web"
New-Development-Site -iisPort 44301 -directoryPath "$PsScriptRoot\..\..\Sharpsolutions.Edt.Api"

 # Run your code that needs to be elevated here
 Write-Host -NoNewLine "Press any key to continue..."
 $null = $Host.UI.RawUI.ReadKey("NoEcho,IncludeKeyDown")