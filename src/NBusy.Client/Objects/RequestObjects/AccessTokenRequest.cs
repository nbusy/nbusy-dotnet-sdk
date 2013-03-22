// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AccessTokenRequest.cs" company="NBusy">
//   Copyright (c) Teoman Soygul. All rights reserved. See License.md in the project root for license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace NBusy.Client.Objects.RequestObjects
{
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	public class AccessTokenRequest
	{
		/// <summary>
		/// Gets or sets the ID of the client application that is requesting the access token.
		/// </summary>
		public int ApplicationId { get; set; }

		/// <summary>
		/// Gets or sets the URI to redirect the user to after granting the access token. Redirect URI must have the
		/// same base domain as the client application domain registered before.
		/// </summary>
		[Required(ErrorMessage = "Redirect URI parameter cannot be blank.")]
		public string RedirectUri { get; set; }

		/// <summary>
		/// Gets or sets the additional access rights that are requested. If there is no scope defined,
		/// basic access rights will be granted. Requesting a token with least possible privileges will
		/// increase the application security.
		/// </summary>
		public List<string> Scope { get; set; }

		/// <summary>
		/// Gets or sets the ID of the user that the access token is requested for. If this field is not specified, a valid
		/// username must be supplied.
		/// </summary>
		public int UserId { get; set; }

		/// <summary>
		/// Gets or sets the username of the user that the access token is requested for. If this field is not specified,
		/// a valid user ID must be supplied.
		/// </summary>
		public string Username { get; set; }
	}
}