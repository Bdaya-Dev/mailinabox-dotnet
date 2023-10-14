# Bdaya.MailInABox.Api.MFAApi

All URIs are relative to *https://box.example.com/admin*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**MfaStatus**](MFAApi.md#mfastatus) | **POST** /mfa/status | Retrieve MFA status for you or another user |
| [**MfaTotpDisable**](MFAApi.md#mfatotpdisable) | **POST** /mfa/disable | Disable multi-factor authentication for you or another user |
| [**MfaTotpEnable**](MFAApi.md#mfatotpenable) | **POST** /mfa/totp/enable | Enable TOTP authentication |

<a id="mfastatus"></a>
# **MfaStatus**
> MfaStatusResponse MfaStatus ()

Retrieve MFA status for you or another user

Retrieves which type of MFA is used and configuration

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bdaya.MailInABox.Api;
using Bdaya.MailInABox.Client;
using Bdaya.MailInABox.Model;

namespace Example
{
    public class MfaStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://box.example.com/admin";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MFAApi(config);

            try
            {
                // Retrieve MFA status for you or another user
                MfaStatusResponse result = apiInstance.MfaStatus();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MFAApi.MfaStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MfaStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve MFA status for you or another user
    ApiResponse<MfaStatusResponse> response = apiInstance.MfaStatusWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MFAApi.MfaStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**MfaStatusResponse**](MfaStatusResponse.md)

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

<a id="mfatotpdisable"></a>
# **MfaTotpDisable**
> string MfaTotpDisable (string mfaId = null)

Disable multi-factor authentication for you or another user

Disables multi-factor authentication for the currently logged-in admin user or another user if a 'user' parameter is submitted. Either disables all multi-factor authentication methods or the method corresponding to the optional property `mfa_id`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bdaya.MailInABox.Api;
using Bdaya.MailInABox.Client;
using Bdaya.MailInABox.Model;

namespace Example
{
    public class MfaTotpDisableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://box.example.com/admin";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MFAApi(config);
            var mfaId = "mfaId_example";  // string |  (optional) 

            try
            {
                // Disable multi-factor authentication for you or another user
                string result = apiInstance.MfaTotpDisable(mfaId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MFAApi.MfaTotpDisable: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MfaTotpDisableWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Disable multi-factor authentication for you or another user
    ApiResponse<string> response = apiInstance.MfaTotpDisableWithHttpInfo(mfaId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MFAApi.MfaTotpDisableWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **mfaId** | **string** |  | [optional]  |

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
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="mfatotpenable"></a>
# **MfaTotpEnable**
> string MfaTotpEnable (string secret, string code, string label = null)

Enable TOTP authentication

Enables TOTP authentication for the currently logged-in admin user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bdaya.MailInABox.Api;
using Bdaya.MailInABox.Client;
using Bdaya.MailInABox.Model;

namespace Example
{
    public class MfaTotpEnableExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://box.example.com/admin";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MFAApi(config);
            var secret = "secret_example";  // string | 
            var code = "code_example";  // string | 
            var label = "label_example";  // string |  (optional) 

            try
            {
                // Enable TOTP authentication
                string result = apiInstance.MfaTotpEnable(secret, code, label);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MFAApi.MfaTotpEnable: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MfaTotpEnableWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Enable TOTP authentication
    ApiResponse<string> response = apiInstance.MfaTotpEnableWithHttpInfo(secret, code, label);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MFAApi.MfaTotpEnableWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **secret** | **string** |  |  |
| **code** | **string** |  |  |
| **label** | **string** |  | [optional]  |

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

