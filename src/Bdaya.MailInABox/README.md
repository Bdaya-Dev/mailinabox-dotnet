# Created with Openapi Generator

<a id="cli"></a>
## Run the following powershell command to generate the library

```ps1
$properties = @(
    'apiName=Api',
    'targetFramework=net7.0',
    'validatable=true',
    'nullableReferenceTypes=true',
    'hideGenerationTimestamp=true',
    'packageVersion=1.0.0',
    'packageAuthors=OpenAPI',
    'packageCompany=OpenAPI',
    'packageCopyright=No Copyright',
    'packageDescription=A library generated from a OpenAPI doc',
    'licenseId=MIT',
    'packageName=Bdaya.MailInABox',
    'packageTags=',
    'packageTitle=OpenAPI Library'
) -join ","

$global = @(
    'apiDocs=true',
    'modelDocs=true',
    'apiTests=true',
    'modelTests=true'
) -join ","

java -jar "<path>/openapi-generator/modules/openapi-generator-cli/target/openapi-generator-cli.jar" generate `
    -g csharp-netcore `
    -i <your-swagger-file>.yaml `
    -o <your-output-folder> `
    --library generichost `
    --additional-properties $properties `
    --global-property $global `
    --git-host "github.com" `
    --git-repo-id "GIT_REPO_ID" `
    --git-user-id "GIT_USER_ID" `
    --release-note "Initial release"
    # -t templates
```

<a id="usage"></a>
## Using the library in your project

```cs
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Bdaya.MailInABox.Api;
using Bdaya.MailInABox.Client;
using Bdaya.MailInABox.Model;

namespace YourProject
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            var api = host.Services.GetRequiredService<IDNSApi>();
            ApiResponse<string> response = await api.AddDnsCustomARecordAsync("todo");
            string model = response.AsModel();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args)
          .ConfigureApi((context, options) =>
          {
              // the type of token here depends on the api security specifications
              ApiKeyToken token = new("<your token>");
              options.AddTokens(token);

              // optionally choose the method the tokens will be provided with, default is RateLimitProvider
              options.UseProvider<RateLimitProvider<ApiKeyToken>, ApiKeyToken>();

              options.ConfigureJsonOptions((jsonOptions) =>
              {
                  // your custom converters if any
              });

              options.AddApiHttpClients(builder: builder => builder
                .AddRetryPolicy(2)
                .AddTimeoutPolicy(TimeSpan.FromSeconds(5))
                .AddCircuitBreakerPolicy(10, TimeSpan.FromSeconds(30))
                // add whatever middleware you prefer
              );
          });
    }
}
```
<a id="questions"></a>
## Questions

- What about HttpRequest failures and retries?
  If supportsRetry is enabled, you can configure Polly in the ConfigureClients method.
- How are tokens used?
  Tokens are provided by a TokenProvider class. The default is RateLimitProvider which will perform client side rate limiting.
  Other providers can be used with the UseProvider method.
- Does an HttpRequest throw an error when the server response is not Ok?
  It depends how you made the request. If the return type is ApiResponse<T> no error will be thrown, though the Content property will be null. 
  StatusCode and ReasonPhrase will contain information about the error.
  If the return type is T, then it will throw. If the return type is TOrDefault, it will return null.
- How do I validate requests and process responses?
  Use the provided On and After methods in the Api class from the namespace Bdaya.MailInABox.Rest.DefaultApi.
  Or provide your own class by using the generic ConfigureApi method.

<a id="dependencies"></a>
## Dependencies

- [Microsoft.Extensions.Hosting](https://www.nuget.org/packages/Microsoft.Extensions.Hosting/) - 5.0.0 or later
- [Microsoft.Extensions.Http](https://www.nuget.org/packages/Microsoft.Extensions.Http/) - 5.0.0 or later
- [Microsoft.Extensions.Http.Polly](https://www.nuget.org/packages/Microsoft.Extensions.Http.Polly/) - 5.0.1 or later
- [CompareNETObjects](https://www.nuget.org/packages/CompareNETObjects) - 4.61.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 4.7.0 or later

<a id="documentation-for-authorization"></a>
## Documentation for Authorization


Authentication schemes defined for the API:
<a id="basicAuth"></a>
### basicAuth

- **Type**: HTTP basic authentication


## Build
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen

## Api Information
- appName: Mail-in-a-Box
- appVersion: 0.51.0
- appDescription: Mail-in-a-Box API HTTP specification.  # Introduction This API is documented in [**OpenAPI format**](http://spec.openapis.org/oas/v3.0.3). ([View the full HTTP specification](https://raw.githubusercontent.com/mail-in-a-box/mailinabox/api-spec/api/mailinabox.yml).)  All endpoints are relative to &#x60;https://{host}/admin&#x60; and are secured with [&#x60;Basic Access&#x60; authentication](https://en.wikipedia.org/wiki/Basic_access_authentication). If you have multi-factor authentication enabled, authentication with a &#x60;user:password&#x60; combination will fail unless a valid OTP is supplied via the &#x60;x-auth-token&#x60; header. Authentication via a &#x60;user:user_key&#x60; pair is possible without the header being present. 

## [OpenApi Global properties](https://openapi-generator.tech/docs/globals)
- generateAliasAsModel: 
- supportingFiles: 
- models: omitted for brevity
- apis: omitted for brevity
- apiDocs: true
- modelDocs: true
- apiTests: true
- modelTests: true
- withXml: 

## [OpenApi Generator Parameters](https://openapi-generator.tech/docs/generators/csharp-netcore)
- allowUnicodeIdentifiers: 
- apiName: Api
- caseInsensitiveResponseHeaders: 
- conditionalSerialization: true
- disallowAdditionalPropertiesIfNotPresent: false
- gitHost: github.com
- gitRepoId: GIT_REPO_ID
- gitUserId: GIT_USER_ID
- hideGenerationTimestamp: true
- interfacePrefix: I
- library: generichost
- licenseId: MIT
- modelPropertyNaming: 
- netCoreProjectFile: false
- nonPublicApi: false
- nullableReferenceTypes: true
- optionalAssemblyInfo: 
- optionalEmitDefaultValues: false
- optionalMethodArgument: true
- optionalProjectFile: 
- packageAuthors: OpenAPI
- packageCompany: OpenAPI
- packageCopyright: No Copyright
- packageDescription: A library generated from a OpenAPI doc
- packageGuid: {0FDF89E0-5F7E-4278-8885-DB7ED61D6EDE}
- packageName: Bdaya.MailInABox
- packageTags: 
- packageTitle: OpenAPI Library
- packageVersion: 1.0.0
- releaseNote: Initial release
- returnICollection: false
- sortParamsByRequiredFlag: 
- sourceFolder: src
- targetFramework: net7.0
- useCollection: false
- useDateTimeOffset: false
- useOneOfDiscriminatorLookup: false
- validatable: true
For more information, please visit [https://mailinabox.email/](https://mailinabox.email/)

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project.
