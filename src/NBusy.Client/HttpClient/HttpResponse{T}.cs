// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HttpResponse{T}.cs" company="NBusy">
//   Copyright (c) Teoman Soygul. All rights reserved. See License.md in the project root for license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace NBusy.Client.HttpClient
{
	using System.Net.Http;
	using System.Threading.Tasks;

	public class HttpResponse<T> : IHttpResponse<T>
	{
		public HttpResponse(HttpResponseMessage httpResponseMessage)
		{
			this.Message = httpResponseMessage;
		}

		public Task<T> Data
		{
			get
			{
				return this.Message.Content.ReadAsAsync<T>();
			}
		}

		public HttpResponseMessage Message { get; set; }
	}
}