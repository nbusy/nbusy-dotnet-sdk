// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CreateThreadRequest.cs" company="NBusy">
//   Copyright (c) Teoman Soygul. All rights reserved. See License.md in the project root for license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace NBusy.Client.Objects.RequestObjects
{
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	/// <summary>
	/// Represents a thread creation request.
	/// </summary>
	public class CreateThreadRequest
	{
		/// <summary>
		/// Gets or sets the contents of the first message in this thread.
		/// </summary>
		[Required]
		[StringLength(63000, ErrorMessage = "Message length cannot exceed 63000 characters.")]
		public virtual string Message { get; set; }

		/// <summary>
		/// Gets or sets the optional title for this message thread. If no title is specified, thread title will be list names
		/// of all the people participating in this conversation.
		/// </summary>
		public virtual string Title { get; set; }

		/// <summary>
		/// Gets or sets the a list of user IDs that this message thread is targeted to.
		/// </summary>
		[Required]
		public virtual List<int> To { get; set; }
	}
}