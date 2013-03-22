// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IOAuth.cs" company="NBusy">
//   Copyright (c) Teoman Soygul. All rights reserved. See License.md in the project root for license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace NBusy.Client.Resources
{
	using System.Threading.Tasks;

	using NBusy.Client.HttpClient;
	using NBusy.Client.Objects.RequestObjects;

	public interface IOAuth
	{
		Task<IHttpResponse> GetAccessToken(AccessTokenRequest request);
	}
}