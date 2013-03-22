// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AccessToken.cs" company="NBusy">
//   Copyright (c) Teoman Soygul. All rights reserved. See License.md in the project root for license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace NBusy.Client.Objects
{
	using System;

	public class AccessToken
	{
		public string Token { get; set; }

		public DateTime? Expiry { get; set; }
	}
}