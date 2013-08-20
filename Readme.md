# NBusy
NBusy SDK for .NET Framework 4.5. 

## What can it be used for?
Although NBusy API is not publicly accessible yet, this source code can still be used as a nice reference for building [ASP.NET Web API] (http://www.asp.net/web-api) client library packages as it makes very good use of [`HttpClient`] (http://msdn.microsoft.com/en-us/library/system.net.http.httpclient.aspx) (`System.Net.Http`) and the new [async] (http://msdn.microsoft.com/en-us/library/vstudio/hh191443.aspx) features of .NET 4.5. 

If you opt not to use this SDK, you can always access the API directly with simple HTTP requests as follows:
```bash
curl --request GET "https://www.nbusy.com/api/threads/1147?access_token=..."
```

## Documentation
See the [documentation](https://github.com/NBusy/NBusy.SDK/wiki)

## Get it on [NuGet] (https://nuget.org/packages/NBusy/)

```powershell
Install-Package NBusy
```

## Sample Usage
```csharp
var user = new NBusyClient("user-access-token");

var httpResponse = await user.Friends.GetFriends();
httpResponse.Message.EnsureSuccessStatusCode();
var friends = await httpResponse.Data;

foreach (var friend in friends)
{
	Console.WriteLine(friend.FullName);
}
```

## Changelog
See the [release notes](https://github.com/NBusy/NBusy.SDK/blob/master/ReleaseNotes.md)
	
## LICENSE
[Apache 2.0 License](https://github.com/NBusy/NBusy.SDK/blob/master/License.md)
