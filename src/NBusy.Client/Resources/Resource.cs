// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Resource.cs" company="NBusy">
//   Copyright (c) Teoman Soygul. All rights reserved. See License.md in the project root for license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace NBusy.Client.Resources
{
	using NBusy.Client.HttpClient;

	public abstract class Resource
	{
		protected readonly INBusyHttpClient HttpClient;

		protected Resource(INBusyHttpClient httpClient)
		{
			this.HttpClient = httpClient;
		}
	}
}