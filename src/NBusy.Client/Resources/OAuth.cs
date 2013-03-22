// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OAuth.cs" company="NBusy">
//   Copyright (c) Teoman Soygul. All rights reserved. See License.md in the project root for license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace NBusy.Client.Resources
{
	using System.Threading.Tasks;

	using NBusy.Client.HttpClient;
	using NBusy.Client.Objects.RequestObjects;

	public class OAuth : Resource, IOAuth
	{
		public const string ResourceUri = "OAuth";

		public OAuth(INBusyHttpClient httpClient)
			: base(httpClient)
		{
		}

		public Task<IHttpResponse> GetAccessToken(AccessTokenRequest request)
		{
			return this.HttpClient.Get(ResourceUri, request);
		}
	}
}