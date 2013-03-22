// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OAuthMessageHandler.cs" company="NBusy">
//   Copyright (c) Teoman Soygul. All rights reserved. See License.md in the project root for license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace NBusy.Client.HttpClient
{
	using System;
	using System.Net.Http;
	using System.Threading;
	using System.Threading.Tasks;

	public class OAuthMessageHandler : DelegatingHandler
	{
		private readonly string accessToken;

		public OAuthMessageHandler(string accessToken, HttpMessageHandler innerHandler)
			: base(innerHandler)
		{
			this.accessToken = accessToken;
		}

		protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			if (this.accessToken != null)
			{
				var uri = request.RequestUri;
				var uriBuilder = new UriBuilder(uri);

				var query = uri.ParseQueryString();
				query.Add("access_token", this.accessToken);
				uriBuilder.Query = query.ToString();

				request.RequestUri = uriBuilder.Uri;
			}

			return base.SendAsync(request, cancellationToken);
		}
	}
}