# Bdaya.MailInABox.Api.SSLApi

All URIs are relative to *https://box.example.com/admin*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GenerateSSLCSR**](SSLApi.md#generatesslcsr) | **POST** /ssl/csr/{domain} | Generate SSL CSR |
| [**GetSSLStatus**](SSLApi.md#getsslstatus) | **GET** /ssl/status | Get SSL status |
| [**InstallSSLCertificate**](SSLApi.md#installsslcertificate) | **POST** /ssl/install | Install SSL certificate |
| [**ProvisionSSLCertificates**](SSLApi.md#provisionsslcertificates) | **POST** /ssl/provision | Provision SSL certificates |

<a id="generatesslcsr"></a>
# **GenerateSSLCSR**
> string GenerateSSLCSR (string domain, string countrycode)

Generate SSL CSR

Generates a Certificate Signing Request (CSR) for a domain & country code. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bdaya.MailInABox.Api;
using Bdaya.MailInABox.Client;
using Bdaya.MailInABox.Model;

namespace Example
{
    public class GenerateSSLCSRExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://box.example.com/admin";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SSLApi(config);
            var domain = "domain_example";  // string | Domain to generate CSR for.
            var countrycode = "countrycode_example";  // string | 

            try
            {
                // Generate SSL CSR
                string result = apiInstance.GenerateSSLCSR(domain, countrycode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SSLApi.GenerateSSLCSR: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GenerateSSLCSRWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Generate SSL CSR
    ApiResponse<string> response = apiInstance.GenerateSSLCSRWithHttpInfo(domain, countrycode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SSLApi.GenerateSSLCSRWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domain** | **string** | Domain to generate CSR for. |  |
| **countrycode** | **string** |  |  |

### Return type

**string**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: text/html


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **400** | Bad request |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getsslstatus"></a>
# **GetSSLStatus**
> SSLStatusResponse GetSSLStatus ()

Get SSL status

Returns the SSL status for all domains.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bdaya.MailInABox.Api;
using Bdaya.MailInABox.Client;
using Bdaya.MailInABox.Model;

namespace Example
{
    public class GetSSLStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://box.example.com/admin";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SSLApi(config);

            try
            {
                // Get SSL status
                SSLStatusResponse result = apiInstance.GetSSLStatus();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SSLApi.GetSSLStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSSLStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get SSL status
    ApiResponse<SSLStatusResponse> response = apiInstance.GetSSLStatusWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SSLApi.GetSSLStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**SSLStatusResponse**](SSLStatusResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/html


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="installsslcertificate"></a>
# **InstallSSLCertificate**
> string InstallSSLCertificate (string domain, string cert, string chain)

Install SSL certificate

Installs a custom certificate. The chain certificate is optional. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bdaya.MailInABox.Api;
using Bdaya.MailInABox.Client;
using Bdaya.MailInABox.Model;

namespace Example
{
    public class InstallSSLCertificateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://box.example.com/admin";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SSLApi(config);
            var domain = "domain_example";  // string | Hostname format.
            var cert = "cert_example";  // string | TLS/SSL certificate.
            var chain = "chain_example";  // string | TLS/SSL intermediate chain (if provided, else empty string).

            try
            {
                // Install SSL certificate
                string result = apiInstance.InstallSSLCertificate(domain, cert, chain);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SSLApi.InstallSSLCertificate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InstallSSLCertificateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Install SSL certificate
    ApiResponse<string> response = apiInstance.InstallSSLCertificateWithHttpInfo(domain, cert, chain);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SSLApi.InstallSSLCertificateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **domain** | **string** | Hostname format. |  |
| **cert** | **string** | TLS/SSL certificate. |  |
| **chain** | **string** | TLS/SSL intermediate chain (if provided, else empty string). |  |

### Return type

**string**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: text/html


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **400** | Bad request |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="provisionsslcertificates"></a>
# **ProvisionSSLCertificates**
> SSLCertificatesProvisionResponse ProvisionSSLCertificates ()

Provision SSL certificates

Provisions certificates for all domains. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bdaya.MailInABox.Api;
using Bdaya.MailInABox.Client;
using Bdaya.MailInABox.Model;

namespace Example
{
    public class ProvisionSSLCertificatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://box.example.com/admin";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SSLApi(config);

            try
            {
                // Provision SSL certificates
                SSLCertificatesProvisionResponse result = apiInstance.ProvisionSSLCertificates();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SSLApi.ProvisionSSLCertificates: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProvisionSSLCertificatesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Provision SSL certificates
    ApiResponse<SSLCertificatesProvisionResponse> response = apiInstance.ProvisionSSLCertificatesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SSLApi.ProvisionSSLCertificatesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**SSLCertificatesProvisionResponse**](SSLCertificatesProvisionResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/html


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

