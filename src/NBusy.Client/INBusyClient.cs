// --------------------------------------------------------------------------------------------------------------------
// <copyright file="INBusyClient.cs" company="NBusy">
//   Copyright (c) Teoman Soygul. All rights reserved. See License.md in the project root for license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace NBusy.Client
{
	using NBusy.Client.Resources;

	/// <summary>
	/// NBusy API client providing access to all available resources.
	/// </summary>
	public interface INBusyClient
	{
		IFriends Friends { get; }

		IMessages Messages { get; }

		IOAuth OAuth { get; }

		IThreads Threads { get; }

		IUsers Users { get; }
	}
}