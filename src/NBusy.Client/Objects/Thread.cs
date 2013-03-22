// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Thread.cs" company="NBusy">
//   Copyright (c) Teoman Soygul. All rights reserved. See License.md in the project root for license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace NBusy.Client.Objects
{
	using System;
	using System.Collections.Generic;

	/// <summary>
	/// Represents a message thread.
	/// </summary>
	public class Thread
	{
		/// <summary>
		/// Gets or sets the unique ID for this message thread.
		/// </summary>
		public virtual int Id { get; set; }

		/// <summary>
		/// Gets or sets the number of messages in the thread.
		/// </summary>
		public virtual int MessageCount { get; set; }

		/// <summary>
		/// Gets or sets a list of messages contained in this thread.
		/// </summary>
		public virtual List<MessageObject> Messages { get; set; }

		/// <summary>
		/// Gets or sets the list of thread participants.
		/// </summary>
		public virtual List<User> Participants { get; set; }

		/// <summary>
		/// Gets or sets the optional title for this thread.
		/// </summary>
		public virtual string Title { get; set; }

		/// <summary>
		/// Gets or sets the number of unread messages in the thread.
		/// </summary>
		public virtual int UnreadCount { get; set; }

		/// <summary>
		/// Gets or sets the time that this thread was last updated.
		/// </summary>
		public virtual DateTime UpdatedTime { get; set; }
	}
}