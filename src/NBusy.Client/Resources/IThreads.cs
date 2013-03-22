// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IThreads.cs" company="NBusy">
//   Copyright (c) Teoman Soygul. All rights reserved. See License.md in the project root for license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace NBusy.Client.Resources
{
	using System.Collections.Generic;
	using System.Threading.Tasks;

	using NBusy.Client.HttpClient;
	using NBusy.Client.Objects;
	using NBusy.Client.Objects.RequestObjects;

	/// <summary>
	/// Provides access to message threads.
	/// </summary>
	public interface IThreads
	{
		/// <summary>
		/// Creates a new message thread.
		/// </summary>
		/// <param name="thread">The new message thread object.</param>
		/// <returns>The newly created message thread object with its unique ID. Redirect is also set to point to the newly created object.</returns>
		Task<IHttpResponse<Thread>> CreateThread(CreateThreadRequest thread);

		/// <summary>
		/// Retrieves the latest one-to-one message thread between the current user (denoted by the access token) and a target user (denoted by user ID).
		/// </summary>
		/// <param name="userId">ID of the target user to retrieve the one-to-one message with the current user.</param>
		/// <returns>One-to-one message thread between target user and current user. 404 if no such thread exists yet.</returns>
		Task<IHttpResponse<Thread>> GetOneToOneThread(int userId);

		/// <summary>
		/// Retrieves messages threads for the current user denoted by the access token.
		/// </summary>
		/// <returns>A list of message threads.</returns>
		Task<IHttpResponse<List<Thread>>> GetThreads();
	}
}