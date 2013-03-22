// --------------------------------------------------------------------------------------------------------------------
// <copyright file="INBusyHttpClient.cs" company="NBusy">
//   Copyright (c) Teoman Soygul. All rights reserved. See License.md in the project root for license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace NBusy.Client.HttpClient
{
	using System.Threading.Tasks;

	public interface INBusyHttpClient
	{
		Task<IHttpResponse> Delete(string resource, params object[] parameters);

		Task<IHttpResponse<T>> Get<T>(string resource, params object[] parameters);

		Task<IHttpResponse> Get(string resource, params object[] parameters);

		Task<IHttpResponse<T>> Post<T>(string resource, T value, params object[] parameters);

		// For situations where request and response types are different
		Task<IHttpResponse<TResponse>> Post<TResponse, TRequest>(string resource, TRequest value, params object[] parameters);

		Task<IHttpResponse> Put<T>(string resource, T value, params object[] parameters);
	}
}