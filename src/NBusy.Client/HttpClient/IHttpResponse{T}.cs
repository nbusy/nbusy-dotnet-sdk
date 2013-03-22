// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IHttpResponse{T}.cs" company="NBusy">
//   Copyright (c) Teoman Soygul. All rights reserved. See License.md in the project root for license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace NBusy.Client.HttpClient
{
	using System.Net.Http;
	using System.Threading.Tasks;

	/// <summary>
	/// Encapsulates an HTTP response message and the associated serialized data (content) of the message separately. 
	/// </summary>
	/// <typeparam name="T">Type of the object (generally DTO) to deserialize the message content into.</typeparam>
	public interface IHttpResponse<T>
	{
		/// <summary>
		/// Gets deserialized HTTP response message content. <see cref="HttpResponseMessage.Content"/> content will be null after this property is accessed.
		/// </summary>
		Task<T> Data { get; }

		/// <summary>
		/// Gets or sets the HTTP response message.
		/// </summary>
		HttpResponseMessage Message { get; set; }
	}
}