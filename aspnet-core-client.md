# ASP.NET Core *HttpClient*

Using Web APIs from ASP.NET Core


<!-- .slide: class="left" -->
## Basics

* [`System.Net.Http.HttpClient`](https://docs.microsoft.com/en-us/dotnet/api/system.net.http.httpclient)
* JSON support
  * In the past: [Json.NET](https://www.newtonsoft.com/json)
  * Now [built-in in .NET Core 3](https://devblogs.microsoft.com/dotnet/try-the-new-system-text-json-apis/)
* Do *not* create a new `HttpClient` whenever you need one
  * Use single, static `HttpClient` in command line tools or WPF apps
  * Use [`IHttpClientFactory`](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/http-requests) in ASP.NET Core
* In practice, consider generating type-safe client
  * [*ReFit*](https://github.com/reactiveui/refit)
  * [*NSwag*](https://github.com/RicoSuter/NSwag)


<!-- .slide: class="left" -->
## Data Transfer Objects

```csharp
<!--#include file="aspnet-core/0040-consume-web-api/DataTransferObjects.cs" -->
```


<!-- .slide: class="left" -->
## Getting Data

```csharp
<!--#include file="aspnet-core/0040-consume-web-api/HttpGet.cs" -->
```


<!-- .slide: class="left" -->
## Writing Data

```csharp
<!--#include file="aspnet-core/0040-consume-web-api/HttpPost.cs" -->
```


<!-- .slide: class="left" -->
## Swagger aka Open API

* Set of tools for Web API development
* Original name was *Swagger*, today it is called *Open API*
* Design APIs with [Open API specification language](https://swagger.io/specification/)
  * Version 2: Wide-spread, robust tooling, lack of important features
  * Version 3: More features, not supported everywhere
* You can already read Swagger files because you got them as homework and exam specs
  * Example: [Contact List sample](https://github.com/rstropek/htl-mobile-computing-5/blob/master/aspnet-core/9010-contact-list/swagger.yaml)
* In ASP.NET Core, you can generate Swagger from your code
  * [NSwag](https://github.com/RicoSuter/NSwag) (we will use that)
  * [Swashbuckle](https://github.com/domaindrivendev/Swashbuckle.AspNetCore)


<!-- .slide: class="left" -->
## Add NSwag

* Open your ASP.NET Core 3 Web API in Visual Studio
* Install NuGet package [*NSwag.AspNetCore*](https://www.nuget.org/packages/NSwag.AspNetCore/)
* Follow [guide for installing in *Startup.cs*](https://github.com/RicoSuter/NSwag#usage-in-c)
  * See also [Microsoft docs](https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-nswag)
  * [Customize](https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-nswag#customize-api-documentation) generated API documentation as needed
* Start your API
  * [https://localhost:5001/swagger/](https://localhost:5001/swagger/) to get Swagger UI
  * [https://localhost:5001/swagger/v1/swagger.json](https://localhost:5001/swagger/v1/swagger.json) to get Swagger specification document


<!-- .slide: class="left" -->
## Client Generation

* Download and install [NSwag Studio](http://rsuter.com/Projects/NSwagStudio/installer.php)
* Start *NSwag Studio*
* Paste your Swagger file
* Generate C# client
