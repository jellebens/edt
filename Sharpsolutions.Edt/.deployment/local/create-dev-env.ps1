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




New-Development-Site -iisPort 44300 -directoryPath "$PsScriptRoot\..\..\Sharpsolutions.Edt.Web"
New-Development-Site -iisPort 44301 -directoryPath "$PsScriptRoot\..\..\Sharpsolutions.Edt.Api"
