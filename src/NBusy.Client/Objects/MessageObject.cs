// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MessageObject.cs" company="NBusy">
//   Copyright (c) Teoman Soygul. All rights reserved. See License.md in the project root for license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace NBusy.Client.Objects
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	public class MessageObject
	{
		public virtual DateTime? CreatedTime { get; set; }

		/// <summary>
		/// Gets or sets the user that have sent this message.
		/// </summary>
		public virtual User From { get; set; }

		public virtual int Id { get; set; }

		[Required]
		[StringLength(63000, ErrorMessage = "Message length cannot exceed 63000 characters.")]
		public virtual string Message { get; set; }

		/// <summary>
		/// Gets or sets the ID of the thread that this message belongs to.
		/// </summary>
		public virtual int ThreadId { get; set; }

		/// <summary>
		/// Gets or sets the list of message recipients.
		/// </summary>
		public virtual List<User> To { get; set; }
	}
}