// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Messages.cs" company="NBusy">
//   Copyright (c) Teoman Soygul. All rights reserved. See License.md in the project root for license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace NBusy.Client.Resources
{
	using System.Collections.Generic;
	using System.Threading.Tasks;

	using NBusy.Client.HttpClient;
	using NBusy.Client.Objects;

	public class Messages : Resource, IMessages
	{
		public const string ResourceUri = "Messages";

		public Messages(INBusyHttpClient httpClient)
			: base(httpClient)
		{
		}

		public Task<IHttpResponse<MessageObject>> CreateMessage(MessageObject message)
		{
			return this.HttpClient.Post(ResourceUri, message);
		}

		public Task<IHttpResponse> DeleteMessage(int id)
		{
			return this.HttpClient.Delete(ResourceUri, new { id });
		}

		public Task<IHttpResponse<MessageObject>> GetMessage(int id)
		{
			return this.HttpClient.Get<MessageObject>(ResourceUri, new { id });
		}

		public Task<IHttpResponse<List<MessageObject>>> GetMessagesByThread(int threadId)
		{
			return this.HttpClient.Get<List<MessageObject>>(ResourceUri, new { threadId });
		}

		public Task<IHttpResponse<List<MessageObject>>> GetUnreadMessages()
		{
			return this.HttpClient.Get<List<MessageObject>>(ResourceUri);
		}

		public Task<IHttpResponse> UpdateMessage(MessageObject message)
		{
			return this.HttpClient.Put(ResourceUri, message);
		}
	}
}