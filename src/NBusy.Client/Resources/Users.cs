// --------------------------------------------------------------------------------------------------------------------
// <copyright file="users.cs" company="NBusy">
//   Copyright (c) Teoman Soygul. All rights reserved. See License.md in the project root for license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace NBusy.Client.Resources
{
	using System.Threading.Tasks;

	using NBusy.Client.HttpClient;
	using NBusy.Client.Objects;

	public class Users : Resource, IUsers
	{
		public const string ResourceUri = "Users";

		public Users(INBusyHttpClient httpClient)
			: base(httpClient)
		{
		}

		public Task<IHttpResponse<User>> AuthenticateUser(string uniqueIdentifier, string password)
		{
			return this.HttpClient.Get<User>(ResourceUri, new { uniqueIdentifier, password });
		}

		public Task<IHttpResponse<User>> GetUser()
		{
			return this.HttpClient.Get<User>(ResourceUri);
		}

		public Task<IHttpResponse<User>> GetUser(int id)
		{
			return this.HttpClient.Get<User>(ResourceUri, new { id });
		}

		public Task<IHttpResponse<User>> GetUser(string uniqueIdentifier)
		{
			return this.HttpClient.Get<User>(ResourceUri, new { uniqueIdentifier });
		}
	}
}