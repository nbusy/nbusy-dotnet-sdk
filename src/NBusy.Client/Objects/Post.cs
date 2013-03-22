// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Post.cs" company="NBusy">
//   Copyright (c) Teoman Soygul. All rights reserved. See License.md in the project root for license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace NBusy.Client.Objects
{
	using System.Collections.Generic;

	/// <summary>
	/// Post on a user's wall.
	/// </summary>
	public class Post
	{
		public int Id { get; set; }

		public List<MessageObject> Messages { get; set; }
	}
}