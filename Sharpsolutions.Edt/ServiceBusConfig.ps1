# To be run in Service Bus PowerShell Console which has Service Bus installed.

# Create new SB Farm
New-SBFarm -SBFarmDBConnectionString 'Data Source=.;Initial Catalog=SbManagementDB;Integrated Security=True;User ID=;Password=;Encrypt=False' -InternalPortRangeStart 9000 -HttpsPort 9355 -TcpPort 9354 -MessageBrokerPort 9356 -RPHttpsPort 9359 -AmqpPort 5672 -AmqpsPort 5671 -RunAsAccount 'sbUser' -AdminGroup 'BUILTIN\Administrators' -GatewayDBConnectionString 'Data Source=.;Initial Catalog=SbGatewayDatabase;Integrated Security=True;User ID=;Password=;Encrypt=False' -FarmCertificateThumbprint 'ABD53144CA89EF19C2947F17A6567BD298FA028A' -EncryptionCertificateThumbprint 'ABD53144CA89EF19C2947F17A6567BD298FA028A' -MessageContainerDBConnectionString 'Data Source=.;Initial Catalog=SBMessageContainer01;Integrated Security=True;User ID=;Password=;Encrypt=False' -Verbose;

# To be run in Service Bus PowerShell Console which has Service Bus installed.

# Add SB Host
$SBRunAsPassword = ConvertTo-SecureString -AsPlainText  -Force  -String '***** Replace with RunAs Password for Service Bus ******' -Verbose;


Add-SBHost -SBFarmDBConnectionString 'Data Source=.;Initial Catalog=SbManagementDB;Integrated Security=True;User ID=;Password=;Encrypt=False' -RunAsPassword $SBRunAsPassword -EnableFirewallRules $true -Verbose;

Try
{
    # Create new SB Namespace
    New-SBNamespace -Name 'ServiceBusDefaultNamespace' -AddressingScheme 'Path' -ManageUsers 'Jelle' -Verbose;

}
Catch [system.InvalidOperationException]
{
}

New-SBMessageContainer -SBFarmDBConnectionString 'Data Source=.;Initial Catalog=SbManagementDB;Integrated Security=True;User ID=;Password=;Encrypt=False' -ContainerDBConnectionString 'Data Source=.;Initial Catalog=SBMessageContainer02;Integrated Security=True;User ID=;Password=;Encrypt=False' -Verbose;
New-SBMessageContainer -SBFarmDBConnectionString 'Data Source=.;Initial Catalog=SbManagementDB;Integrated Security=True;User ID=;Password=;Encrypt=False' -ContainerDBConnectionString 'Data Source=.;Initial Catalog=SBMessageContainer03;Integrated Security=True;User ID=;Password=;Encrypt=False' -Verbose;

# Get SB Client Configuration
$SBClientConfiguration = Get-SBClientConfiguration -Namespaces 'ServiceBusDefaultNamespace' -Verbose;
