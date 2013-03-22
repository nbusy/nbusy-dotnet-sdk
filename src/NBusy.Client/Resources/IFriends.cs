// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IFriends.cs" company="NBusy">
//   Copyright (c) Teoman Soygul. All rights reserved. See License.md in the project root for license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace NBusy.Client.Resources
{
	using System.Collections.Generic;
	using System.Threading.Tasks;

	using NBusy.Client.HttpClient;
	using NBusy.Client.Objects;

	/// <summary>
	/// Provides access to friends of a user.
	/// </summary>
	public interface IFriends
	{
		/// <summary>
		/// Retrieves the friends list for the current user denoted by the access token.
		/// </summary>
		/// <returns>A list of user objects.</returns>
		Task<IHttpResponse<List<User>>> GetFriends();
	}
}