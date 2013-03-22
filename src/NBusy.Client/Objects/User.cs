// --------------------------------------------------------------------------------------------------------------------
// <copyright file="User.cs" company="NBusy">
//   Copyright (c) Teoman Soygul. All rights reserved. See License.md in the project root for license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace NBusy.Client.Objects
{
	using System.ComponentModel.DataAnnotations;

	public class User
	{
		public virtual string Email { get; set; }

		[Required(ErrorMessage = "Each user should have a first name.")]
		public virtual string FirstName { get; set; }

		public virtual string FullName { get; set; }

		public virtual int Id { get; set; }

		[Required(ErrorMessage = "Each user should have a last name.")]
		public virtual string LastName { get; set; }

		/// <summary>
		/// Gets or sets the user's home page.
		/// </summary>
		public virtual string Link { get; set; }

		public virtual string Locale { get; set; }

		/// <summary>
		/// Gets or sets the user's mobile phone number. This may contain non numeric characters.
		/// </summary>
		public virtual string Mobile { get; set; }

		/// <summary>
		/// Gets or sets the user's profile photo.
		/// </summary>
		public virtual byte[] Photo { get; set; }

		public virtual string Username { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the the user's account was verified.
		/// </summary>
		public virtual bool Verified { get; set; }
	}
}