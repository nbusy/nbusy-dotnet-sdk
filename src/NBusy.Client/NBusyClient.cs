// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NBusyClient.cs" company="NBusy">
//   Copyright (c) Teoman Soygul. All rights reserved. See License.md in the project root for license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace NBusy.Client
{
	using System.Net.Http;

	using NBusy.Client.HttpClient;
	using NBusy.Client.Resources;

	/// <summary>
	/// Thread safe implementation of <see cref="INBusyClient"/> interface. Both the class itself and the members are inherently
	/// thread safe so it is recommended to use this class as a singleton object per user.
	/// </summary>
	public class NBusyClient : INBusyClient
	{
		// We're using singleton scope for System.Net.Http.HttpClient since it is thread safe for the functions that
		// we use as per the documentation (see: http://msdn.microsoft.com/en-us/library/hh193681.aspx)
		protected readonly INBusyHttpClient HttpClient;

		private IFriends friends;

		private IMessages messages;

		private IOAuth oAuth;

		private IThreads threads;

		private IUsers users;

		public NBusyClient(string accessToken, HttpMessageHandler messageHandler)
		{
			this.HttpClient = new NBusyHttpClient(accessToken, messageHandler);
		}

		public NBusyClient(string accessToken)
		{
			this.HttpClient = new NBusyHttpClient(accessToken);
		}

		public IFriends Friends
		{
			get
			{
				return this.friends ?? (this.friends = new Friends(this.HttpClient));
			}
		}

		public IMessages Messages
		{
			get
			{
				return this.messages ?? (this.messages = new Messages(this.HttpClient));
			}
		}

		public IOAuth OAuth
		{
			get
			{
				return this.oAuth ?? (this.oAuth = new OAuth(this.HttpClient));
			}
		}

		public IThreads Threads
		{
			get
			{
				return this.threads ?? (this.threads = new Threads(this.HttpClient));
			}
		}

		public IUsers Users
		{
			get
			{
				return this.users ?? (this.users = new Users(this.HttpClient));
			}
		}
	}
}