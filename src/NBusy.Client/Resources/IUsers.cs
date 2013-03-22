// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IUsers.cs" company="NBusy">
//   Copyright (c) Teoman Soygul. All rights reserved. See License.md in the project root for license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace NBusy.Client.Resources
{
	using System.Threading.Tasks;

	using NBusy.Client.HttpClient;
	using NBusy.Client.Objects;

	/// <summary>
	/// Defines methods to access user specific functionality.
	/// </summary>
	public interface IUsers
	{
		/// <summary>
		/// Retrieves an authentic user by an identifier and password.
		/// </summary>
		/// <param name="uniqueIdentifier">Unique identifier (e-mail or phone number or the username) of the user to be found.</param>
		/// <param name="password">Password of the authentic user to be retrieved.</param>
		/// <returns>The user object. 404 if the user is not found by the unique identifier provided. 401 if the password mismatches.</returns>
		Task<IHttpResponse<User>> AuthenticateUser(string uniqueIdentifier, string password);

		/// <summary>
		/// Retrieves the current user denoted by the access token.
		/// </summary>
		/// <returns>User object.</returns>
		Task<IHttpResponse<User>> GetUser();

		/// <summary>
		/// Retrieves a user by ID.
		/// </summary>
		/// <param name="id">ID of the user to be found.</param>
		/// <returns>User object if found. 404 otherwise.</returns>
		Task<IHttpResponse<User>> GetUser(int id);

		/// <summary>
		/// Retrieves a user by a unique identifier (e-mail or phone number or username).
		/// Type of the identifier is automatically detected using regex.
		/// </summary>
		/// <param name="uniqueIdentifier">Unique identifier (e-mail or phone number or the username) of the user to be found.</param>
		/// <returns>User object if found. 404 otherwise.</returns>
		Task<IHttpResponse<User>> GetUser(string uniqueIdentifier);
	}
}