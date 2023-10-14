# Bdaya.MailInABox.Api.SystemApi

All URIs are relative to *https://box.example.com/admin*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetSystemBackupConfig**](SystemApi.md#getsystembackupconfig) | **GET** /system/backup/config | Get system backup config |
| [**GetSystemBackupStatus**](SystemApi.md#getsystembackupstatus) | **GET** /system/backup/status | Get system backup status |
| [**GetSystemPrivacyStatus**](SystemApi.md#getsystemprivacystatus) | **GET** /system/privacy | Get system privacy status |
| [**GetSystemRebootStatus**](SystemApi.md#getsystemrebootstatus) | **GET** /system/reboot | Get system reboot status |
| [**GetSystemStatus**](SystemApi.md#getsystemstatus) | **POST** /system/status | Get system status |
| [**GetSystemUpdates**](SystemApi.md#getsystemupdates) | **GET** /system/updates | Get system updates |
| [**GetSystemUpstreamVersion**](SystemApi.md#getsystemupstreamversion) | **POST** /system/latest-upstream-version | Get system upstream version |
| [**GetSystemVersion**](SystemApi.md#getsystemversion) | **GET** /system/version | Get system version |
| [**RebootSystem**](SystemApi.md#rebootsystem) | **POST** /system/reboot | Reboot system |
| [**UpdateSystemBackupConfig**](SystemApi.md#updatesystembackupconfig) | **POST** /system/backup/config | Update system backup config |
| [**UpdateSystemPackages**](SystemApi.md#updatesystempackages) | **POST** /system/update-packages | Update system packages |
| [**UpdateSystemPrivacy**](SystemApi.md#updatesystemprivacy) | **POST** /system/privacy | Update system privacy |

<a id="getsystembackupconfig"></a>
# **GetSystemBackupConfig**
> SystemBackupConfigResponse GetSystemBackupConfig ()

Get system backup config

Returns the system backup config.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bdaya.MailInABox.Api;
using Bdaya.MailInABox.Client;
using Bdaya.MailInABox.Model;

namespace Example
{
    public class GetSystemBackupConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://box.example.com/admin";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SystemApi(config);

            try
            {
                // Get system backup config
                SystemBackupConfigResponse result = apiInstance.GetSystemBackupConfig();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemApi.GetSystemBackupConfig: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSystemBackupConfigWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get system backup config
    ApiResponse<SystemBackupConfigResponse> response = apiInstance.GetSystemBackupConfigWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemApi.GetSystemBackupConfigWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**SystemBackupConfigResponse**](SystemBackupConfigResponse.md)

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

<a id="getsystembackupstatus"></a>
# **GetSystemBackupStatus**
> SystemBackupStatusResponse GetSystemBackupStatus ()

Get system backup status

Returns the system backup status.  If the list of backups is empty, this implies no backups have been made yet. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bdaya.MailInABox.Api;
using Bdaya.MailInABox.Client;
using Bdaya.MailInABox.Model;

namespace Example
{
    public class GetSystemBackupStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://box.example.com/admin";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SystemApi(config);

            try
            {
                // Get system backup status
                SystemBackupStatusResponse result = apiInstance.GetSystemBackupStatus();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemApi.GetSystemBackupStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSystemBackupStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get system backup status
    ApiResponse<SystemBackupStatusResponse> response = apiInstance.GetSystemBackupStatusWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemApi.GetSystemBackupStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**SystemBackupStatusResponse**](SystemBackupStatusResponse.md)

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

<a id="getsystemprivacystatus"></a>
# **GetSystemPrivacyStatus**
> bool GetSystemPrivacyStatus ()

Get system privacy status

Returns system privacy (new-version check) status.  Response:    - `true`: Private, new-version checks will not be performed   - `false`: Not private, new-version checks will be performed 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bdaya.MailInABox.Api;
using Bdaya.MailInABox.Client;
using Bdaya.MailInABox.Model;

namespace Example
{
    public class GetSystemPrivacyStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://box.example.com/admin";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SystemApi(config);

            try
            {
                // Get system privacy status
                bool result = apiInstance.GetSystemPrivacyStatus();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemApi.GetSystemPrivacyStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSystemPrivacyStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get system privacy status
    ApiResponse<bool> response = apiInstance.GetSystemPrivacyStatusWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemApi.GetSystemPrivacyStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**bool**

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

<a id="getsystemrebootstatus"></a>
# **GetSystemRebootStatus**
> bool GetSystemRebootStatus ()

Get system reboot status

Returns the system reboot status.  Response:    - `true`: A reboot is required   - `false`: A reboot is not required 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bdaya.MailInABox.Api;
using Bdaya.MailInABox.Client;
using Bdaya.MailInABox.Model;

namespace Example
{
    public class GetSystemRebootStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://box.example.com/admin";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SystemApi(config);

            try
            {
                // Get system reboot status
                bool result = apiInstance.GetSystemRebootStatus();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemApi.GetSystemRebootStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSystemRebootStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get system reboot status
    ApiResponse<bool> response = apiInstance.GetSystemRebootStatusWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemApi.GetSystemRebootStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**bool**

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

<a id="getsystemstatus"></a>
# **GetSystemStatus**
> List&lt;StatusEntry&gt; GetSystemStatus ()

Get system status

Returns an array of statuses which can include headings. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bdaya.MailInABox.Api;
using Bdaya.MailInABox.Client;
using Bdaya.MailInABox.Model;

namespace Example
{
    public class GetSystemStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://box.example.com/admin";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SystemApi(config);

            try
            {
                // Get system status
                List<StatusEntry> result = apiInstance.GetSystemStatus();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemApi.GetSystemStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSystemStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get system status
    ApiResponse<List<StatusEntry>> response = apiInstance.GetSystemStatusWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemApi.GetSystemStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;StatusEntry&gt;**](StatusEntry.md)

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

<a id="getsystemupdates"></a>
# **GetSystemUpdates**
> string GetSystemUpdates ()

Get system updates

Returns system (apt) updates.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bdaya.MailInABox.Api;
using Bdaya.MailInABox.Client;
using Bdaya.MailInABox.Model;

namespace Example
{
    public class GetSystemUpdatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://box.example.com/admin";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SystemApi(config);

            try
            {
                // Get system updates
                string result = apiInstance.GetSystemUpdates();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemApi.GetSystemUpdates: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSystemUpdatesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get system updates
    ApiResponse<string> response = apiInstance.GetSystemUpdatesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemApi.GetSystemUpdatesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**string**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/html


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getsystemupstreamversion"></a>
# **GetSystemUpstreamVersion**
> string GetSystemUpstreamVersion ()

Get system upstream version

Returns Mail-in-a-Box upstream version.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bdaya.MailInABox.Api;
using Bdaya.MailInABox.Client;
using Bdaya.MailInABox.Model;

namespace Example
{
    public class GetSystemUpstreamVersionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://box.example.com/admin";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SystemApi(config);

            try
            {
                // Get system upstream version
                string result = apiInstance.GetSystemUpstreamVersion();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemApi.GetSystemUpstreamVersion: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSystemUpstreamVersionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get system upstream version
    ApiResponse<string> response = apiInstance.GetSystemUpstreamVersionWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemApi.GetSystemUpstreamVersionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**string**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/html


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getsystemversion"></a>
# **GetSystemVersion**
> string GetSystemVersion ()

Get system version

Returns installed Mail-in-a-Box version.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bdaya.MailInABox.Api;
using Bdaya.MailInABox.Client;
using Bdaya.MailInABox.Model;

namespace Example
{
    public class GetSystemVersionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://box.example.com/admin";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SystemApi(config);

            try
            {
                // Get system version
                string result = apiInstance.GetSystemVersion();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemApi.GetSystemVersion: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSystemVersionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get system version
    ApiResponse<string> response = apiInstance.GetSystemVersionWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemApi.GetSystemVersionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**string**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/html


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="rebootsystem"></a>
# **RebootSystem**
> string RebootSystem ()

Reboot system

Reboots the system.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bdaya.MailInABox.Api;
using Bdaya.MailInABox.Client;
using Bdaya.MailInABox.Model;

namespace Example
{
    public class RebootSystemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://box.example.com/admin";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SystemApi(config);

            try
            {
                // Reboot system
                string result = apiInstance.RebootSystem();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemApi.RebootSystem: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RebootSystemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reboot system
    ApiResponse<string> response = apiInstance.RebootSystemWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemApi.RebootSystemWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**string**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/html


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatesystembackupconfig"></a>
# **UpdateSystemBackupConfig**
> string UpdateSystemBackupConfig (int minAge, string target, string targetUser, string targetPass)

Update system backup config

Updates the system backup config.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bdaya.MailInABox.Api;
using Bdaya.MailInABox.Client;
using Bdaya.MailInABox.Model;

namespace Example
{
    public class UpdateSystemBackupConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://box.example.com/admin";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SystemApi(config);
            var minAge = 56;  // int | 
            var target = "target_example";  // string | 
            var targetUser = "targetUser_example";  // string | 
            var targetPass = "targetPass_example";  // string | 

            try
            {
                // Update system backup config
                string result = apiInstance.UpdateSystemBackupConfig(minAge, target, targetUser, targetPass);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemApi.UpdateSystemBackupConfig: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSystemBackupConfigWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update system backup config
    ApiResponse<string> response = apiInstance.UpdateSystemBackupConfigWithHttpInfo(minAge, target, targetUser, targetPass);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemApi.UpdateSystemBackupConfigWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **minAge** | **int** |  |  |
| **target** | **string** |  |  |
| **targetUser** | **string** |  |  |
| **targetPass** | **string** |  |  |

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

<a id="updatesystempackages"></a>
# **UpdateSystemPackages**
> string UpdateSystemPackages ()

Update system packages

Updates system (apt) packages.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bdaya.MailInABox.Api;
using Bdaya.MailInABox.Client;
using Bdaya.MailInABox.Model;

namespace Example
{
    public class UpdateSystemPackagesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://box.example.com/admin";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SystemApi(config);

            try
            {
                // Update system packages
                string result = apiInstance.UpdateSystemPackages();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemApi.UpdateSystemPackages: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSystemPackagesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update system packages
    ApiResponse<string> response = apiInstance.UpdateSystemPackagesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemApi.UpdateSystemPackagesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**string**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/html


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatesystemprivacy"></a>
# **UpdateSystemPrivacy**
> string UpdateSystemPrivacy (SystemPrivacyStatus value)

Update system privacy

Updates system privacy (new-version checks).  Request:    - `value: private`: Disable new version checks   - `value: off`: Enable new version checks 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bdaya.MailInABox.Api;
using Bdaya.MailInABox.Client;
using Bdaya.MailInABox.Model;

namespace Example
{
    public class UpdateSystemPrivacyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://box.example.com/admin";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new SystemApi(config);
            var value = new SystemPrivacyStatus(); // SystemPrivacyStatus | 

            try
            {
                // Update system privacy
                string result = apiInstance.UpdateSystemPrivacy(value);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemApi.UpdateSystemPrivacy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSystemPrivacyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update system privacy
    ApiResponse<string> response = apiInstance.UpdateSystemPrivacyWithHttpInfo(value);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemApi.UpdateSystemPrivacyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **value** | [**SystemPrivacyStatus**](SystemPrivacyStatus.md) |  |  |

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

