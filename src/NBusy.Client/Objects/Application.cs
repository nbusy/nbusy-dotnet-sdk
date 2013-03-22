// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Application.cs" company="NBusy">
//   Copyright (c) Teoman Soygul. All rights reserved. See License.md in the project root for license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace NBusy.Client.Objects
{
	public class Application
	{
		/// <summary>
		/// Gets or sets the application domain. i.e. nbusy.com
		/// </summary>
		public string Domain { get; set; }

		public int Id { get; set; }

		/// <summary>
		/// Gets or sets the name of the application. i.e. NBusy
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the full URL of the application. i.e. https://www.nbusy.com/
		/// </summary>
		public string Url { get; set; }
	}
}