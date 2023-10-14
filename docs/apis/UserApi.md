# Bdaya.MailInABox.Api.UserApi

All URIs are relative to *https://box.example.com/admin*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Login**](UserApi.md#login) | **POST** /login | Exchange a username and password for a session API key. |
| [**Logout**](UserApi.md#logout) | **POST** /logout | Invalidates a session API key. |

<a id="login"></a>
# **Login**
> MeResponse Login ()

Exchange a username and password for a session API key.

Returns user information and a session API key.  Authenticate a user by supplying the auth token as a base64 encoded string in format `email:password` using basic authentication headers.  If successful, a long-lived `api_key` is returned which can be used for subsequent requests to the API in place of the password. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bdaya.MailInABox.Api;
using Bdaya.MailInABox.Client;
using Bdaya.MailInABox.Model;

namespace Example
{
    public class LoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://box.example.com/admin";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new UserApi(config);

            try
            {
                // Exchange a username and password for a session API key.
                MeResponse result = apiInstance.Login();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.Login: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LoginWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Exchange a username and password for a session API key.
    ApiResponse<MeResponse> response = apiInstance.LoginWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.LoginWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**MeResponse**](MeResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="logout"></a>
# **Logout**
> LogoutResponse Logout ()

Invalidates a session API key.

Invalidates a session API key so that it cannot be used after this API call. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bdaya.MailInABox.Api;
using Bdaya.MailInABox.Client;
using Bdaya.MailInABox.Model;

namespace Example
{
    public class LogoutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://box.example.com/admin";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new UserApi(config);

            try
            {
                // Invalidates a session API key.
                LogoutResponse result = apiInstance.Logout();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.Logout: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LogoutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Invalidates a session API key.
    ApiResponse<LogoutResponse> response = apiInstance.LogoutWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.LogoutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**LogoutResponse**](LogoutResponse.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

