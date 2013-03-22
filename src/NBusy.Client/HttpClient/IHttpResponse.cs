// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IHttpResponse.cs" company="NBusy">
//   Copyright (c) Teoman Soygul. All rights reserved. See License.md in the project root for license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace NBusy.Client.HttpClient
{
	using System.Net.Http;
	using System.Threading.Tasks;

	/// <summary>
	/// Encapsulates an HTTP response message and the associated data (content) of the message separately. 
	/// </summary>
	public interface IHttpResponse
	{
		/// <summary>
		/// Gets HTTP response message content as a string. Message content will be null after this property is accessed.
		/// </summary>
		Task<string> Data { get; }

		/// <summary>
		/// Gets or sets the HTTP response message.
		/// </summary>
		HttpResponseMessage Message { get; set; }
	}
}