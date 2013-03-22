// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NBusyHttpClient.cs" company="NBusy">
//   Copyright (c) Teoman Soygul. All rights reserved. See License.md in the project root for license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace NBusy.Client.HttpClient
{
	using System;
	using System.ComponentModel;
	using System.Net;
	using System.Net.Http;
	using System.Net.Http.Headers;
	using System.Threading.Tasks;

	public class NBusyHttpClient : HttpClient, INBusyHttpClient
	{
		public NBusyHttpClient(string accessToken)
			: this(accessToken, new HttpClientHandler())
		{
		}

		public NBusyHttpClient(string accessToken, HttpMessageHandler messageHandler)
			: base(new OAuthMessageHandler(accessToken, messageHandler))
		{
			this.BaseAddress = new Uri("https://www.nbusy.com/Service/");
		}

		public async Task<IHttpResponse> Delete(string resource, params object[] parameters)
		{
			return new HttpResponse(await this.DeleteAsync(this.BuildQuery(resource, parameters)));
		}

		public async Task<IHttpResponse<T>> Get<T>(string resource, params object[] parameters)
		{
			return new HttpResponse<T>(await this.GetAsync(this.BuildQuery(resource, parameters)));
		}

		public async Task<IHttpResponse> Get(string resource, params object[] parameters)
		{
			return new HttpResponse(await this.GetAsync(this.BuildQuery(resource, parameters)));
		}

		public async Task<IHttpResponse<T>> Post<T>(string resource, T value, params object[] parameters)
		{
			return new HttpResponse<T>(await this.PostAsJsonAsync(this.BuildQuery(resource, parameters).ToString(), value));
		}

		public async Task<IHttpResponse<TResponse>> Post<TResponse, TRequest>(string resource, TRequest value, params object[] parameters)
		{
			return new HttpResponse<TResponse>(await this.PostAsJsonAsync(this.BuildQuery(resource, parameters).ToString(), value));
		}

		public async Task<IHttpResponse> Put<T>(string resource, T value, params object[] parameters)
		{
			return new HttpResponse(await this.PutAsJsonAsync(this.BuildQuery(resource, parameters).ToString(), value));
		}

		private Uri BuildQuery(string resource, params object[] parameters)
		{
			var uriBuilder = new UriBuilder(this.BaseAddress);
			uriBuilder.Path += resource;

			var query = uriBuilder.Uri.ParseQueryString();

			foreach (var parameter in parameters)
			{
				foreach (PropertyDescriptor property in TypeDescriptor.GetProperties(parameter))
				{
					var value = property.GetValue(parameter);
					if (value == null)
					{
						continue;
					}

					if (property.Name == "id")
					{
						uriBuilder.Path += "/" + value;
					}
					else
					{
						query.Add(property.Name, value.ToString());
					}
				}
			}

			uriBuilder.Query = query.ToString();

			return uriBuilder.Uri;
		}
	}
}