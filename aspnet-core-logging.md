# ASP.NET Core Logging

Logging in ASP.NET Core Apps


<!-- .slide: class="left" -->
## Basics

* ASP.NET Core contains an *extensible* mechanism for logging
  * Log providers for different targets (e.g. console, debugger, Windows Event Log)
  * 3rd party log providers/frameworks (e.g. [Serilog](https://serilog.net/))
* Meaningful log providers [registered by default](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/logging/#add-providers)
* Practical tip (out-of-scope for this course): Consider [*Application Insights*](https://docs.microsoft.com/en-us/azure/azure-monitor/app/app-insights-overview)


<!-- .slide: class="left" -->
## Get a Logger

```csharp
<!--#include file="aspnet-core/0050-logging/Controllers/MathController.cs" -->
```


<!-- .slide: class="left" -->
## Write Logs

```csharp
<!--#include file="aspnet-core/0050-logging/Controllers/MathControllerDiv.cs" -->
```


<!-- .slide: class="left" -->
## Exercise: Serilog

* **Careful**: Referenced documentation is for ASP.NET Core 2, you are using version 3. You cannot blindly copy the code!
* *Seq*
  * Make yourself familiar with the features of the [*Seq* log viewer](https://datalust.co/seq)
  * Install the [*Seq* log viewer](https://datalust.co/download) (free in single-user mode)
* Extend [*logging* sample from GitHub](https://github.com/rstropek/htl-mobile-computing-5/tree/master/aspnet-core/0050-logging) locally on your computer
  * Follow the [guidelines in Serilog docs](https://github.com/serilog/serilog-aspnetcore#instructions) to install Serilog in *logging* sample
  * Follow the [guidelines in the Seq sink](https://github.com/serilog/serilog-sinks-seq#getting-started]) to install it in *logging* sample
* Try it:
  * Start Seq and then *logging* sample
  * Try *http://localhost:5000/api/math/div?x=9&y=0*, see error log in Seq
