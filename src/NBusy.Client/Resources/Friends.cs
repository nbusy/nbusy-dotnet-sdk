// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Friends.cs" company="NBusy">
//   Copyright (c) Teoman Soygul. All rights reserved. See License.md in the project root for license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace NBusy.Client.Resources
{
	using System.Collections.Generic;
	using System.Threading.Tasks;

	using NBusy.Client.HttpClient;
	using NBusy.Client.Objects;

	public class Friends : Resource, IFriends
	{
		public const string ResourceUri = "Friends";

		public Friends(INBusyHttpClient httpClient)
			: base(httpClient)
		{
		}

		public Task<IHttpResponse<List<User>>> GetFriends()
		{
			return this.HttpClient.Get<List<User>>(ResourceUri);
		}
	}
}