// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Threads.cs" company="NBusy">
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

	public class Threads : Resource, IThreads
	{
		public const string ResourceUri = "Threads";

		public Threads(INBusyHttpClient httpClient)
			: base(httpClient)
		{
		}

		public Task<IHttpResponse<Thread>> CreateThread(CreateThreadRequest thread)
		{
			return this.HttpClient.Post<Thread, CreateThreadRequest>(ResourceUri, thread);
		}

		public Task<IHttpResponse<Thread>> GetOneToOneThread(int userId)
		{
			return this.HttpClient.Get<Thread>(ResourceUri, new { userId });
		}

		public Task<IHttpResponse<List<Thread>>> GetThreads()
		{
			return this.HttpClient.Get<List<Thread>>(ResourceUri);
		}
	}
}