// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IMessages.cs" company="NBusy">
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
	/// Provides access to user messages.
	/// </summary>
	public interface IMessages
	{
		/// <summary>
		/// Creates a new message.
		/// </summary>
		/// <param name="message">Message object.</param>
		/// <returns>The newly created message object with the unique ID. Also the redirect is set to point to this new message object.</returns>
		Task<IHttpResponse<MessageObject>> CreateMessage(MessageObject message);

		/// <summary>
		/// Deletes a message by its ID.
		/// </summary>
		/// <param name="id">ID of the message to remove.</param>
		/// <returns>HTTP status code 200 (OK), if the operation was successful.</returns>
		Task<IHttpResponse> DeleteMessage(int id);

		/// <summary>
		/// Retrieves a message by its ID.
		/// </summary>
		/// <param name="id">ID of the message to retrieve.</param>
		/// <returns>A message object. 404 if the message was not found.</returns>
		Task<IHttpResponse<MessageObject>> GetMessage(int id);

		/// <summary>
		/// Retrieves the list of messages by thread ID.
		/// </summary>
		/// <param name="threadId">ID of the user's message thread to retrieve the messages for.</param>
		/// <returns>A list of messages.</returns>
		Task<IHttpResponse<List<MessageObject>>> GetMessagesByThread(int threadId);

		/// <summary>
		/// Retrieves a list of unread messages for the current user.
		/// </summary>
		/// <returns>A list of messages.</returns>
		Task<IHttpResponse<List<MessageObject>>> GetUnreadMessages();

		/// <summary>
		/// Updates a message.
		/// </summary>
		/// <param name="message">Message object with updated fields.</param>
		/// <returns>HTTP status code 204 (no content), if the operation was successful.</returns>
		Task<IHttpResponse> UpdateMessage(MessageObject message);
	}
}