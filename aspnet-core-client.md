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

