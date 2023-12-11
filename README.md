# WmiLight [![build](https://github.com/MartinKuschnik/WmiLight/workflows/.NET%20Core/badge.svg)](https://github.com/MartinKuschnik/WmiLight/actions) [![NuGet Status](http://img.shields.io/nuget/v/WmiLight.svg?style=flat)](https://www.nuget.org/packages/WmiLight/)

## What is WmiLight?
A simple and light wmi framework. It has only one function: sending WMI queries.
It's a subset of the System.Management.Instrumentation namespace.

## In which case should you use WmiLight?
The .Net framework implementation has one big problem.
It leaks a little bit memory on each remote operation.
Use this framework if your application is a service or runs a long time and you're sending a lot of remote queries.

## Installation

This project is being distributed as a NuGet package, so open your Package Manager Console window and execute the following command:

<a href="https://www.nuget.org/packages/WmiLight/" target="_blank">
<img title="NuGet" src="https://github.com/MartinKuschnik/WmiLight/blob/master/doc/pics/install_nuget_package.JPG" alt="NuGet"/>
</a>



## How to use?

Query all running processes for the local machine:
```C#
using (WmiConnection con = new WmiConnection())
{
    foreach (WmiObject process in con.CreateQuery("SELECT * FROM Win32_Process"))
    {
        Console.WriteLine(process["Name"]);
    }
}
```

Query all partitions for a remote machine with credentials:
```C#

var opt = new WmiConnectionOptions() { EnablePackageEncryption = true };
var cred = new NetworkCredential("USERNAME", "PASSWORD", "DOMAIN");

using (WmiConnection con = new WmiConnection(@"\\MACHINENAME\root\cimv2", cred, opt))
{
    foreach (WmiObject partition in con.CreateQuery("SELECT * FROM Win32_DiskPartition"))
    {
        Console.WriteLine(partition["Name"]);
    }
}
```
Query all partitions for a remote machine with Integrated Windows Authentication:
```C#
var opt = new WmiConnectionOptions() { EnablePackageEncryption = true };

using (WmiConnection con = new WmiConnection(@"\\MACHINENAME\root\cimv2", opt))
{
    foreach (WmiObject partition in con.CreateQuery("SELECT * FROM Win32_DiskPartition"))
    {
        Console.WriteLine(partition["Name"]);
    }
}
```

## Other benefits:

* easy usage

* no distinction between local and remote queries

* Debugger Preview 

    ![Debugger_Preview](https://github.com/MartinKuschnik/WmiLight/blob/master/doc/pics/debugger_preview.jpg "Debugger Preview")

## How to exclude `WmiLight.Native.dll` when publishing native aot exe in .net 8.0?
You can modify your project file by referring to the following examples:
``` xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net8.0</TargetFramework>
    <PublishAot>True</PublishAot>
  </PropertyGroup>

  <ItemGroup>
    <!-- Add WmiLight Package -->
    <PackageReference Include="WmiLight" Version="5.1.0" GeneratePathProperty="true" />

    <!-- https://learn.microsoft.com/en-us/dotnet/core/deploying/native-aot/interop -->
    <DirectPInvoke Include="WmiLight.Native" />
    <NativeLibrary Include="wbemuuid.lib" Condition="$(RuntimeIdentifier.StartsWith('win'))" />
    <NativeLibrary Include="$(PkgWmiLight)\lib\native\$(RuntimeIdentifier)\WmiLight.Native.lib" Condition="$(RuntimeIdentifier.StartsWith('win'))" />
  </ItemGroup>

  <!-- The DLL file will be copied when it is published, so we need to remove it -->
  <Target Name="RemoveFileToPublish" AfterTargets="ComputeResolvedFilesToPublishList">
    <ItemGroup>
      <ResolvedFileToPublish Remove="@(ResolvedFileToPublish)" Condition="'%(ResolvedFileToPublish.RelativePath)' == 'WmiLight.Native.dll'" />
    </ItemGroup>
  </Target>

</Project>
```


