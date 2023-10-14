# Bdaya.MailInABox.Api.MailApi

All URIs are relative to *https://box.example.com/admin*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddMailUser**](MailApi.md#addmailuser) | **POST** /mail/users/add | Add mail user |
| [**AddMailUserPrivilege**](MailApi.md#addmailuserprivilege) | **POST** /mail/users/privileges/add | Add mail user privilege |
| [**GetMailAliases**](MailApi.md#getmailaliases) | **GET** /mail/aliases | Get mail aliases |
| [**GetMailDomains**](MailApi.md#getmaildomains) | **GET** /mail/domains | Get mail domains |
| [**GetMailUserPrivileges**](MailApi.md#getmailuserprivileges) | **GET** /mail/users/privileges | Get mail user privileges |
| [**GetMailUsers**](MailApi.md#getmailusers) | **GET** /mail/users | Get mail users |
| [**RemoveMailAlias**](MailApi.md#removemailalias) | **POST** /mail/aliases/remove | Remove mail alias |
| [**RemoveMailUser**](MailApi.md#removemailuser) | **POST** /mail/users/remove | Remove mail user |
| [**RemoveMailUserPrivilege**](MailApi.md#removemailuserprivilege) | **POST** /mail/users/privileges/remove | Remove mail user privilege |
| [**SetMailUserPassword**](MailApi.md#setmailuserpassword) | **POST** /mail/users/password | Set mail user password |
| [**UpsertMailAlias**](MailApi.md#upsertmailalias) | **POST** /mail/aliases/add | Upsert mail alias |

<a id="addmailuser"></a>
# **AddMailUser**
> string AddMailUser (MailUserPrivilege privileges, string email, string password)

Add mail user

Adds a new mail user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bdaya.MailInABox.Api;
using Bdaya.MailInABox.Client;
using Bdaya.MailInABox.Model;

namespace Example
{
    public class AddMailUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://box.example.com/admin";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MailApi(config);
            var privileges = new MailUserPrivilege(); // MailUserPrivilege | 
            var email = "email_example";  // string | Email format.
            var password = "password_example";  // string | 

            try
            {
                // Add mail user
                string result = apiInstance.AddMailUser(privileges, email, password);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MailApi.AddMailUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddMailUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add mail user
    ApiResponse<string> response = apiInstance.AddMailUserWithHttpInfo(privileges, email, password);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MailApi.AddMailUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **privileges** | [**MailUserPrivilege**](MailUserPrivilege.md) |  |  |
| **email** | **string** | Email format. |  |
| **password** | **string** |  |  |

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

<a id="addmailuserprivilege"></a>
# **AddMailUserPrivilege**
> string AddMailUserPrivilege (MailUserPrivilege privilege, string email)

Add mail user privilege

Adds a privilege to an existing mail user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bdaya.MailInABox.Api;
using Bdaya.MailInABox.Client;
using Bdaya.MailInABox.Model;

namespace Example
{
    public class AddMailUserPrivilegeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://box.example.com/admin";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MailApi(config);
            var privilege = new MailUserPrivilege(); // MailUserPrivilege | 
            var email = "email_example";  // string | Email format.

            try
            {
                // Add mail user privilege
                string result = apiInstance.AddMailUserPrivilege(privilege, email);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MailApi.AddMailUserPrivilege: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddMailUserPrivilegeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add mail user privilege
    ApiResponse<string> response = apiInstance.AddMailUserPrivilegeWithHttpInfo(privilege, email);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MailApi.AddMailUserPrivilegeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **privilege** | [**MailUserPrivilege**](MailUserPrivilege.md) |  |  |
| **email** | **string** | Email format. |  |

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

<a id="getmailaliases"></a>
# **GetMailAliases**
> List&lt;MailAliasByDomain&gt; GetMailAliases (MailAliasesResponseFormat format = null)

Get mail aliases

Returns all mail aliases.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bdaya.MailInABox.Api;
using Bdaya.MailInABox.Client;
using Bdaya.MailInABox.Model;

namespace Example
{
    public class GetMailAliasesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://box.example.com/admin";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MailApi(config);
            var format = new MailAliasesResponseFormat(); // MailAliasesResponseFormat | The format of the response. (optional) 

            try
            {
                // Get mail aliases
                List<MailAliasByDomain> result = apiInstance.GetMailAliases(format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MailApi.GetMailAliases: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMailAliasesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get mail aliases
    ApiResponse<List<MailAliasByDomain>> response = apiInstance.GetMailAliasesWithHttpInfo(format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MailApi.GetMailAliasesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **format** | [**MailAliasesResponseFormat**](MailAliasesResponseFormat.md) | The format of the response. | [optional]  |

### Return type

[**List&lt;MailAliasByDomain&gt;**](MailAliasByDomain.md)

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

<a id="getmaildomains"></a>
# **GetMailDomains**
> string GetMailDomains ()

Get mail domains

Returns all mail domains.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bdaya.MailInABox.Api;
using Bdaya.MailInABox.Client;
using Bdaya.MailInABox.Model;

namespace Example
{
    public class GetMailDomainsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://box.example.com/admin";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MailApi(config);

            try
            {
                // Get mail domains
                string result = apiInstance.GetMailDomains();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MailApi.GetMailDomains: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMailDomainsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get mail domains
    ApiResponse<string> response = apiInstance.GetMailDomainsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MailApi.GetMailDomainsWithHttpInfo: " + e.Message);
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

<a id="getmailuserprivileges"></a>
# **GetMailUserPrivileges**
> MailUserPrivilege GetMailUserPrivileges (string email = null)

Get mail user privileges

Returns all privileges for an existing mail user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bdaya.MailInABox.Api;
using Bdaya.MailInABox.Client;
using Bdaya.MailInABox.Model;

namespace Example
{
    public class GetMailUserPrivilegesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://box.example.com/admin";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MailApi(config);
            var email = "email_example";  // string | The email you want to get privileges for. (optional) 

            try
            {
                // Get mail user privileges
                MailUserPrivilege result = apiInstance.GetMailUserPrivileges(email);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MailApi.GetMailUserPrivileges: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMailUserPrivilegesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get mail user privileges
    ApiResponse<MailUserPrivilege> response = apiInstance.GetMailUserPrivilegesWithHttpInfo(email);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MailApi.GetMailUserPrivilegesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **email** | **string** | The email you want to get privileges for. | [optional]  |

### Return type

[**MailUserPrivilege**](MailUserPrivilege.md)

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

<a id="getmailusers"></a>
# **GetMailUsers**
> List&lt;MailUserByDomain&gt; GetMailUsers (MailUsersResponseFormat format = null)

Get mail users

Returns all mail users.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bdaya.MailInABox.Api;
using Bdaya.MailInABox.Client;
using Bdaya.MailInABox.Model;

namespace Example
{
    public class GetMailUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://box.example.com/admin";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MailApi(config);
            var format = new MailUsersResponseFormat(); // MailUsersResponseFormat | The format of the response. (optional) 

            try
            {
                // Get mail users
                List<MailUserByDomain> result = apiInstance.GetMailUsers(format);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MailApi.GetMailUsers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMailUsersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get mail users
    ApiResponse<List<MailUserByDomain>> response = apiInstance.GetMailUsersWithHttpInfo(format);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MailApi.GetMailUsersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **format** | [**MailUsersResponseFormat**](MailUsersResponseFormat.md) | The format of the response. | [optional]  |

### Return type

[**List&lt;MailUserByDomain&gt;**](MailUserByDomain.md)

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

<a id="removemailalias"></a>
# **RemoveMailAlias**
> string RemoveMailAlias (string address)

Remove mail alias

Removes a mail alias.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bdaya.MailInABox.Api;
using Bdaya.MailInABox.Client;
using Bdaya.MailInABox.Model;

namespace Example
{
    public class RemoveMailAliasExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://box.example.com/admin";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MailApi(config);
            var address = "address_example";  // string | Email format.

            try
            {
                // Remove mail alias
                string result = apiInstance.RemoveMailAlias(address);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MailApi.RemoveMailAlias: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveMailAliasWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove mail alias
    ApiResponse<string> response = apiInstance.RemoveMailAliasWithHttpInfo(address);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MailApi.RemoveMailAliasWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **address** | **string** | Email format. |  |

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

<a id="removemailuser"></a>
# **RemoveMailUser**
> string RemoveMailUser (string email)

Remove mail user

Removes an existing mail user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bdaya.MailInABox.Api;
using Bdaya.MailInABox.Client;
using Bdaya.MailInABox.Model;

namespace Example
{
    public class RemoveMailUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://box.example.com/admin";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MailApi(config);
            var email = "email_example";  // string | Email format.

            try
            {
                // Remove mail user
                string result = apiInstance.RemoveMailUser(email);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MailApi.RemoveMailUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveMailUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove mail user
    ApiResponse<string> response = apiInstance.RemoveMailUserWithHttpInfo(email);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MailApi.RemoveMailUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **email** | **string** | Email format. |  |

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

<a id="removemailuserprivilege"></a>
# **RemoveMailUserPrivilege**
> string RemoveMailUserPrivilege (MailUserPrivilege privilege, string email)

Remove mail user privilege

Removes a privilege from an existing mail user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bdaya.MailInABox.Api;
using Bdaya.MailInABox.Client;
using Bdaya.MailInABox.Model;

namespace Example
{
    public class RemoveMailUserPrivilegeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://box.example.com/admin";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MailApi(config);
            var privilege = new MailUserPrivilege(); // MailUserPrivilege | 
            var email = "email_example";  // string | Email format.

            try
            {
                // Remove mail user privilege
                string result = apiInstance.RemoveMailUserPrivilege(privilege, email);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MailApi.RemoveMailUserPrivilege: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveMailUserPrivilegeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove mail user privilege
    ApiResponse<string> response = apiInstance.RemoveMailUserPrivilegeWithHttpInfo(privilege, email);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MailApi.RemoveMailUserPrivilegeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **privilege** | [**MailUserPrivilege**](MailUserPrivilege.md) |  |  |
| **email** | **string** | Email format. |  |

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

<a id="setmailuserpassword"></a>
# **SetMailUserPassword**
> string SetMailUserPassword (string email, string password)

Set mail user password

Sets a password for an existing mail user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bdaya.MailInABox.Api;
using Bdaya.MailInABox.Client;
using Bdaya.MailInABox.Model;

namespace Example
{
    public class SetMailUserPasswordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://box.example.com/admin";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MailApi(config);
            var email = "email_example";  // string | Email format.
            var password = "password_example";  // string | 

            try
            {
                // Set mail user password
                string result = apiInstance.SetMailUserPassword(email, password);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MailApi.SetMailUserPassword: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetMailUserPasswordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set mail user password
    ApiResponse<string> response = apiInstance.SetMailUserPasswordWithHttpInfo(email, password);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MailApi.SetMailUserPasswordWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **email** | **string** | Email format. |  |
| **password** | **string** |  |  |

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

<a id="upsertmailalias"></a>
# **UpsertMailAlias**
> string UpsertMailAlias (int updateIfExists, string address, string forwardsTo, string permittedSenders)

Upsert mail alias

Adds or updates a mail alias. If updating, you need to set `update_if_exists: 1`. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Bdaya.MailInABox.Api;
using Bdaya.MailInABox.Client;
using Bdaya.MailInABox.Model;

namespace Example
{
    public class UpsertMailAliasExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://box.example.com/admin";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new MailApi(config);
            var updateIfExists = 56;  // int | Set to `1` when updating an alias.
            var address = "address_example";  // string | Email format.
            var forwardsTo = "forwardsTo_example";  // string | If adding a regular or catch-all alias, the format needs to be `user@example.com`. Multiple address can be separated by newlines or commas.  If adding a domain alias, the format needs to be `@example.com`. 
            var permittedSenders = "permittedSenders_example";  // string | Mail users that can send mail claiming to be from any address on the alias domain. Multiple address can be separated by newlines or commas.  Leave empty to allow any mail user listed in `forwards_to` to send mail claiming to be from any address on the alias domain. 

            try
            {
                // Upsert mail alias
                string result = apiInstance.UpsertMailAlias(updateIfExists, address, forwardsTo, permittedSenders);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MailApi.UpsertMailAlias: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertMailAliasWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Upsert mail alias
    ApiResponse<string> response = apiInstance.UpsertMailAliasWithHttpInfo(updateIfExists, address, forwardsTo, permittedSenders);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MailApi.UpsertMailAliasWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateIfExists** | **int** | Set to &#x60;1&#x60; when updating an alias. |  |
| **address** | **string** | Email format. |  |
| **forwardsTo** | **string** | If adding a regular or catch-all alias, the format needs to be &#x60;user@example.com&#x60;. Multiple address can be separated by newlines or commas.  If adding a domain alias, the format needs to be &#x60;@example.com&#x60;.  |  |
| **permittedSenders** | **string** | Mail users that can send mail claiming to be from any address on the alias domain. Multiple address can be separated by newlines or commas.  Leave empty to allow any mail user listed in &#x60;forwards_to&#x60; to send mail claiming to be from any address on the alias domain.  |  |

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

