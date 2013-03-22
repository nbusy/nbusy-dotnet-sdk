// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HttpResponse.cs" company="NBusy">
//   Copyright (c) Teoman Soygul. All rights reserved. See License.md in the project root for license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace NBusy.Client.HttpClient
{
	using System.Net.Http;
	using System.Threading.Tasks;

	public class HttpResponse : IHttpResponse
	{
		public HttpResponse(HttpResponseMessage httpResponseMessage)
		{
			this.Message = httpResponseMessage;
		}

		public Task<string> Data
		{
			get
			{
				return this.Message.Content.ReadAsStringAsync();
			}
		}

		public HttpResponseMessage Message { get; set; }
	}
}