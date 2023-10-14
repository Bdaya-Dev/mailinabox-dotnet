# Bdaya.MailInABox.Api.DNSApi

All URIs are relative to *https://box.example.com/admin*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddDnsCustomARecord**](DNSApi.md#adddnscustomarecord) | **POST** /dns/custom/{qname} | Add DNS custom A record |
| [**AddDnsCustomRecord**](DNSApi.md#adddnscustomrecord) | **POST** /dns/custom/{qname}/{rtype} | Add DNS custom record |
| [**AddDnsSecondaryNameserver**](DNSApi.md#adddnssecondarynameserver) | **POST** /dns/secondary-nameserver | Add DNS secondary nameserver |
| [**GetDnsCustomARecordsForQName**](DNSApi.md#getdnscustomarecordsforqname) | **GET** /dns/custom/{qname} | Get DNS custom A records |
| [**GetDnsCustomRecords**](DNSApi.md#getdnscustomrecords) | **GET** /dns/custom | Get DNS custom records |
| [**GetDnsCustomRecordsForQNameAndType**](DNSApi.md#getdnscustomrecordsforqnameandtype) | **GET** /dns/custom/{qname}/{rtype} | Get DNS custom records |
| [**GetDnsDump**](DNSApi.md#getdnsdump) | **GET** /dns/dump | Get DNS dump |
| [**GetDnsSecondaryNameserver**](DNSApi.md#getdnssecondarynameserver) | **GET** /dns/secondary-nameserver | Get DNS secondary nameserver |
| [**GetDnsZonefile**](DNSApi.md#getdnszonefile) | **GET** /dns/zonefile/{zone} | Get DNS zonefile |
| [**GetDnsZones**](DNSApi.md#getdnszones) | **GET** /dns/zones | Get DNS zones |
| [**RemoveDnsCustomARecord**](DNSApi.md#removednscustomarecord) | **DELETE** /dns/custom/{qname} | Remove DNS custom A record |
| [**RemoveDnsCustomRecord**](DNSApi.md#removednscustomrecord) | **DELETE** /dns/custom/{qname}/{rtype} | Remove DNS custom record |
| [**UpdateDns**](DNSApi.md#updatedns) | **POST** /dns/update | Update DNS |
| [**UpdateDnsCustomARecord**](DNSApi.md#updatednscustomarecord) | **PUT** /dns/custom/{qname} | Update DNS custom A record |
| [**UpdateDnsCustomRecord**](DNSApi.md#updatednscustomrecord) | **PUT** /dns/custom/{qname}/{rtype} | Update DNS custom record |

<a id="adddnscustomarecord"></a>
# **AddDnsCustomARecord**
> string AddDnsCustomARecord (string qname, string body)

Add DNS custom A record

Adds a custom DNS A record for the specified query name.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bdaya.MailInABox.Api;
using Bdaya.MailInABox.Client;
using Bdaya.MailInABox.Model;

namespace Example
{
    public class AddDnsCustomARecordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://box.example.com/admin";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DNSApi(config);
            var qname = "qname_example";  // string | DNS query name.
            var body = 1.2.3.4;  // string | 

            try
            {
                // Add DNS custom A record
                string result = apiInstance.AddDnsCustomARecord(qname, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DNSApi.AddDnsCustomARecord: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddDnsCustomARecordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add DNS custom A record
    ApiResponse<string> response = apiInstance.AddDnsCustomARecordWithHttpInfo(qname, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DNSApi.AddDnsCustomARecordWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **qname** | **string** | DNS query name. |  |
| **body** | **string** |  |  |

### Return type

**string**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/html


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **400** | Bad request |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="adddnscustomrecord"></a>
# **AddDnsCustomRecord**
> string AddDnsCustomRecord (DNSRecordType rtype, string qname, string body)

Add DNS custom record

Adds a custom DNS record for the specified query name and type.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bdaya.MailInABox.Api;
using Bdaya.MailInABox.Client;
using Bdaya.MailInABox.Model;

namespace Example
{
    public class AddDnsCustomRecordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://box.example.com/admin";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DNSApi(config);
            var rtype = new DNSRecordType(); // DNSRecordType | Record type
            var qname = "qname_example";  // string | DNS record query name
            var body = 1.2.3.4;  // string | 

            try
            {
                // Add DNS custom record
                string result = apiInstance.AddDnsCustomRecord(rtype, qname, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DNSApi.AddDnsCustomRecord: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddDnsCustomRecordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add DNS custom record
    ApiResponse<string> response = apiInstance.AddDnsCustomRecordWithHttpInfo(rtype, qname, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DNSApi.AddDnsCustomRecordWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **rtype** | [**DNSRecordType**](DNSRecordType.md) | Record type |  |
| **qname** | **string** | DNS record query name |  |
| **body** | **string** |  |  |

### Return type

**string**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/html


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **400** | Bad request |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="adddnssecondarynameserver"></a>
# **AddDnsSecondaryNameserver**
> string AddDnsSecondaryNameserver (string hostnames)

Add DNS secondary nameserver

Adds one or more secondary nameservers. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bdaya.MailInABox.Api;
using Bdaya.MailInABox.Client;
using Bdaya.MailInABox.Model;

namespace Example
{
    public class AddDnsSecondaryNameserverExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://box.example.com/admin";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DNSApi(config);
            var hostnames = "hostnames_example";  // string | Hostnames separated with commas or spaces.

            try
            {
                // Add DNS secondary nameserver
                string result = apiInstance.AddDnsSecondaryNameserver(hostnames);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DNSApi.AddDnsSecondaryNameserver: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddDnsSecondaryNameserverWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add DNS secondary nameserver
    ApiResponse<string> response = apiInstance.AddDnsSecondaryNameserverWithHttpInfo(hostnames);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DNSApi.AddDnsSecondaryNameserverWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **hostnames** | **string** | Hostnames separated with commas or spaces. |  |

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

<a id="getdnscustomarecordsforqname"></a>
# **GetDnsCustomARecordsForQName**
> List&lt;DNSCustomRecord&gt; GetDnsCustomARecordsForQName (string qname)

Get DNS custom A records

Returns all custom A records for the specified query name.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bdaya.MailInABox.Api;
using Bdaya.MailInABox.Client;
using Bdaya.MailInABox.Model;

namespace Example
{
    public class GetDnsCustomARecordsForQNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://box.example.com/admin";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DNSApi(config);
            var qname = "qname_example";  // string | DNS query name.

            try
            {
                // Get DNS custom A records
                List<DNSCustomRecord> result = apiInstance.GetDnsCustomARecordsForQName(qname);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DNSApi.GetDnsCustomARecordsForQName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDnsCustomARecordsForQNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get DNS custom A records
    ApiResponse<List<DNSCustomRecord>> response = apiInstance.GetDnsCustomARecordsForQNameWithHttpInfo(qname);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DNSApi.GetDnsCustomARecordsForQNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **qname** | **string** | DNS query name. |  |

### Return type

[**List&lt;DNSCustomRecord&gt;**](DNSCustomRecord.md)

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

<a id="getdnscustomrecords"></a>
# **GetDnsCustomRecords**
> List&lt;DNSCustomRecord&gt; GetDnsCustomRecords ()

Get DNS custom records

Returns all custom DNS records.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bdaya.MailInABox.Api;
using Bdaya.MailInABox.Client;
using Bdaya.MailInABox.Model;

namespace Example
{
    public class GetDnsCustomRecordsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://box.example.com/admin";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DNSApi(config);

            try
            {
                // Get DNS custom records
                List<DNSCustomRecord> result = apiInstance.GetDnsCustomRecords();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DNSApi.GetDnsCustomRecords: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDnsCustomRecordsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get DNS custom records
    ApiResponse<List<DNSCustomRecord>> response = apiInstance.GetDnsCustomRecordsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DNSApi.GetDnsCustomRecordsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;DNSCustomRecord&gt;**](DNSCustomRecord.md)

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

<a id="getdnscustomrecordsforqnameandtype"></a>
# **GetDnsCustomRecordsForQNameAndType**
> List&lt;DNSCustomRecord&gt; GetDnsCustomRecordsForQNameAndType (DNSRecordType rtype, string qname)

Get DNS custom records

Returns all custom records for the specified query name and type.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bdaya.MailInABox.Api;
using Bdaya.MailInABox.Client;
using Bdaya.MailInABox.Model;

namespace Example
{
    public class GetDnsCustomRecordsForQNameAndTypeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://box.example.com/admin";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DNSApi(config);
            var rtype = new DNSRecordType(); // DNSRecordType | Record type
            var qname = "qname_example";  // string | DNS record query name

            try
            {
                // Get DNS custom records
                List<DNSCustomRecord> result = apiInstance.GetDnsCustomRecordsForQNameAndType(rtype, qname);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DNSApi.GetDnsCustomRecordsForQNameAndType: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDnsCustomRecordsForQNameAndTypeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get DNS custom records
    ApiResponse<List<DNSCustomRecord>> response = apiInstance.GetDnsCustomRecordsForQNameAndTypeWithHttpInfo(rtype, qname);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DNSApi.GetDnsCustomRecordsForQNameAndTypeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **rtype** | [**DNSRecordType**](DNSRecordType.md) | Record type |  |
| **qname** | **string** | DNS record query name |  |

### Return type

[**List&lt;DNSCustomRecord&gt;**](DNSCustomRecord.md)

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

<a id="getdnsdump"></a>
# **GetDnsDump**
> List&lt;List&lt;DNSDumpDomainsInner&gt;&gt; GetDnsDump ()

Get DNS dump

Returns all DNS records.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bdaya.MailInABox.Api;
using Bdaya.MailInABox.Client;
using Bdaya.MailInABox.Model;

namespace Example
{
    public class GetDnsDumpExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://box.example.com/admin";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DNSApi(config);

            try
            {
                // Get DNS dump
                List<List<DNSDumpDomainsInner>> result = apiInstance.GetDnsDump();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DNSApi.GetDnsDump: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDnsDumpWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get DNS dump
    ApiResponse<List<List<DNSDumpDomainsInner>>> response = apiInstance.GetDnsDumpWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DNSApi.GetDnsDumpWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**List<List<DNSDumpDomainsInner>>**

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

<a id="getdnssecondarynameserver"></a>
# **GetDnsSecondaryNameserver**
> DNSSecondaryNameserverResponse GetDnsSecondaryNameserver ()

Get DNS secondary nameserver

Returns a list of nameserver hostnames. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bdaya.MailInABox.Api;
using Bdaya.MailInABox.Client;
using Bdaya.MailInABox.Model;

namespace Example
{
    public class GetDnsSecondaryNameserverExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://box.example.com/admin";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DNSApi(config);

            try
            {
                // Get DNS secondary nameserver
                DNSSecondaryNameserverResponse result = apiInstance.GetDnsSecondaryNameserver();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DNSApi.GetDnsSecondaryNameserver: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDnsSecondaryNameserverWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get DNS secondary nameserver
    ApiResponse<DNSSecondaryNameserverResponse> response = apiInstance.GetDnsSecondaryNameserverWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DNSApi.GetDnsSecondaryNameserverWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**DNSSecondaryNameserverResponse**](DNSSecondaryNameserverResponse.md)

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

<a id="getdnszonefile"></a>
# **GetDnsZonefile**
> string GetDnsZonefile (string zone)

Get DNS zonefile

Returns a DNS zone file for a hostname.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bdaya.MailInABox.Api;
using Bdaya.MailInABox.Client;
using Bdaya.MailInABox.Model;

namespace Example
{
    public class GetDnsZonefileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://box.example.com/admin";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DNSApi(config);
            var zone = "zone_example";  // string | Hostname

            try
            {
                // Get DNS zonefile
                string result = apiInstance.GetDnsZonefile(zone);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DNSApi.GetDnsZonefile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDnsZonefileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get DNS zonefile
    ApiResponse<string> response = apiInstance.GetDnsZonefileWithHttpInfo(zone);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DNSApi.GetDnsZonefileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **zone** | **string** | Hostname |  |

### Return type

**string**

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

<a id="getdnszones"></a>
# **GetDnsZones**
> List&lt;string&gt; GetDnsZones ()

Get DNS zones

Returns an array of all managed top-level domains.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bdaya.MailInABox.Api;
using Bdaya.MailInABox.Client;
using Bdaya.MailInABox.Model;

namespace Example
{
    public class GetDnsZonesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://box.example.com/admin";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DNSApi(config);

            try
            {
                // Get DNS zones
                List<string> result = apiInstance.GetDnsZones();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DNSApi.GetDnsZones: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDnsZonesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get DNS zones
    ApiResponse<List<string>> response = apiInstance.GetDnsZonesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DNSApi.GetDnsZonesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**List<string>**

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

<a id="removednscustomarecord"></a>
# **RemoveDnsCustomARecord**
> string RemoveDnsCustomARecord (string qname, string body)

Remove DNS custom A record

Removes a DNS custom A record for the specified domain & value.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bdaya.MailInABox.Api;
using Bdaya.MailInABox.Client;
using Bdaya.MailInABox.Model;

namespace Example
{
    public class RemoveDnsCustomARecordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://box.example.com/admin";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DNSApi(config);
            var qname = "qname_example";  // string | DNS query name.
            var body = 1.2.3.4;  // string | 

            try
            {
                // Remove DNS custom A record
                string result = apiInstance.RemoveDnsCustomARecord(qname, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DNSApi.RemoveDnsCustomARecord: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveDnsCustomARecordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove DNS custom A record
    ApiResponse<string> response = apiInstance.RemoveDnsCustomARecordWithHttpInfo(qname, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DNSApi.RemoveDnsCustomARecordWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **qname** | **string** | DNS query name. |  |
| **body** | **string** |  |  |

### Return type

**string**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/html


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **400** | Bad request |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="removednscustomrecord"></a>
# **RemoveDnsCustomRecord**
> string RemoveDnsCustomRecord (DNSRecordType rtype, string qname, string body)

Remove DNS custom record

Removes a DNS custom record for the specified domain, type & value.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bdaya.MailInABox.Api;
using Bdaya.MailInABox.Client;
using Bdaya.MailInABox.Model;

namespace Example
{
    public class RemoveDnsCustomRecordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://box.example.com/admin";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DNSApi(config);
            var rtype = new DNSRecordType(); // DNSRecordType | Record type
            var qname = "qname_example";  // string | DNS record query name
            var body = 1.2.3.4;  // string | 

            try
            {
                // Remove DNS custom record
                string result = apiInstance.RemoveDnsCustomRecord(rtype, qname, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DNSApi.RemoveDnsCustomRecord: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveDnsCustomRecordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove DNS custom record
    ApiResponse<string> response = apiInstance.RemoveDnsCustomRecordWithHttpInfo(rtype, qname, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DNSApi.RemoveDnsCustomRecordWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **rtype** | [**DNSRecordType**](DNSRecordType.md) | Record type |  |
| **qname** | **string** | DNS record query name |  |
| **body** | **string** |  |  |

### Return type

**string**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/html


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **400** | Bad request |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatedns"></a>
# **UpdateDns**
> string UpdateDns (int force)

Update DNS

Updates the DNS. Involves creating zone files and restarting `nsd`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bdaya.MailInABox.Api;
using Bdaya.MailInABox.Client;
using Bdaya.MailInABox.Model;

namespace Example
{
    public class UpdateDnsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://box.example.com/admin";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DNSApi(config);
            var force = 56;  // int | Force an update even if mailinabox detects no changes are required.

            try
            {
                // Update DNS
                string result = apiInstance.UpdateDns(force);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DNSApi.UpdateDns: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateDnsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update DNS
    ApiResponse<string> response = apiInstance.UpdateDnsWithHttpInfo(force);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DNSApi.UpdateDnsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **force** | **int** | Force an update even if mailinabox detects no changes are required. |  |

### Return type

**string**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json, text/html


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **400** | Bad request |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatednscustomarecord"></a>
# **UpdateDnsCustomARecord**
> string UpdateDnsCustomARecord (string qname, string body)

Update DNS custom A record

Updates an existing DNS custom A record value for the specified qname.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bdaya.MailInABox.Api;
using Bdaya.MailInABox.Client;
using Bdaya.MailInABox.Model;

namespace Example
{
    public class UpdateDnsCustomARecordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://box.example.com/admin";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DNSApi(config);
            var qname = "qname_example";  // string | DNS query name.
            var body = 1.2.3.4;  // string | 

            try
            {
                // Update DNS custom A record
                string result = apiInstance.UpdateDnsCustomARecord(qname, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DNSApi.UpdateDnsCustomARecord: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateDnsCustomARecordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update DNS custom A record
    ApiResponse<string> response = apiInstance.UpdateDnsCustomARecordWithHttpInfo(qname, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DNSApi.UpdateDnsCustomARecordWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **qname** | **string** | DNS query name. |  |
| **body** | **string** |  |  |

### Return type

**string**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/html


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **400** | Bad request |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatednscustomrecord"></a>
# **UpdateDnsCustomRecord**
> string UpdateDnsCustomRecord (DNSRecordType rtype, string qname, string body)

Update DNS custom record

Updates an existing DNS custom record value for the specified qname and type.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bdaya.MailInABox.Api;
using Bdaya.MailInABox.Client;
using Bdaya.MailInABox.Model;

namespace Example
{
    public class UpdateDnsCustomRecordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://box.example.com/admin";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DNSApi(config);
            var rtype = new DNSRecordType(); // DNSRecordType | Record type
            var qname = "qname_example";  // string | DNS record query name
            var body = 1.2.3.4;  // string | 

            try
            {
                // Update DNS custom record
                string result = apiInstance.UpdateDnsCustomRecord(rtype, qname, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DNSApi.UpdateDnsCustomRecord: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateDnsCustomRecordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update DNS custom record
    ApiResponse<string> response = apiInstance.UpdateDnsCustomRecordWithHttpInfo(rtype, qname, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DNSApi.UpdateDnsCustomRecordWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **rtype** | [**DNSRecordType**](DNSRecordType.md) | Record type |  |
| **qname** | **string** | DNS record query name |  |
| **body** | **string** |  |  |

### Return type

**string**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/html


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **400** | Bad request |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

