# WmiLight [![Build](https://github.com/MartinKuschnik/WmiLight/actions/workflows/build.yml/badge.svg)](https://github.com/MartinKuschnik/WmiLight/actions/workflows/build.yml) [![NuGet Status](http://img.shields.io/nuget/v/WmiLight.svg?style=flat)](https://www.nuget.org/packages/WmiLight/)

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
Get a notification if a process has started:
```C#
var opt = new WmiConnectionOptions() { EnablePackageEncryption = true };

using (WmiConnection con = new WmiConnection(@"\\MACHINENAME\root\cimv2", opt))
{
    using (WmiEventSubscription sub = conncetion.CreateEventSubscription(
            "SELECT * FROM __InstanceCreationEvent WITHIN 2 WHERE TargetInstance ISA 'Win32_Process'", 
            x => Console.WriteLine("Process '{0}' started", x.GetPropertyValue<WmiObject>("TargetInstance").GetPropertyValue<string>("Name"))))
    {
        // ToDo: wait or do some other suff
    }
}
```
ALternative way to get a notification if a process has started:
```C#
var opt = new WmiConnectionOptions() { EnablePackageEncryption = true };

using (WmiConnection con = new WmiConnection(@"\\MACHINENAME\root\cimv2", opt))
{
    using (WmiEventWatcher eventWatcher = conncetion.CreateEventWatcher("SELECT * FROM __InstanceCreationEvent WITHIN 2 WHERE TargetInstance ISA 'Win32_Process'"))
    {
        eventWatcher.EventArrived += EventWatcher_EventArrived;

        eventWatcher.Start();

        // ToDo: wait or do some other suff

        eventWatcher.Stop();

        eventWatcher.EventArrived -= EventWatcher_EventArrived;
    }
}
```

## Native AOT deployment

WmiLight supports Native AOT deployment since [Version 5.0.0](https://github.com/MartinKuschnik/WmiLight/releases/tag/v5.0.0).

It's also possible to link WmiLight statically to have only one executable working without the `WmiLight.dll`. <br/>
To link WmiLight statically, add `<PublishWmiLightStaticallyLinked>true</PublishWmiLightStaticallyLinked>` to your project file.

```xml
<PropertyGroup>
    <PublishAot>true</PublishAot>
    <PublishWmiLightStaticallyLinked>true</PublishWmiLightStaticallyLinked>
</PropertyGroup>
```

## Other benefits:

* easy usage

* support for Native AOT deployment

* no distinction between local and remote queries

* Debugger Preview 

    ![Debugger_Preview](https://github.com/MartinKuschnik/WmiLight/blob/master/doc/pics/debugger_preview.jpg "Debugger Preview")

