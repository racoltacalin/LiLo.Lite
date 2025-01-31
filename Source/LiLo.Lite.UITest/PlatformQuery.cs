﻿// <copyright file="PlatformQuery.cs" company="InternetWideWorld.com">
// Copyright (c) George Leithead, InternetWideWorld.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
// </copyright>

namespace LiLo.Lite.UITest
{
	using System;
	using Xamarin.UITest;
	using Xamarin.UITest.Queries;

	/// <summary>Platform query.</summary>
	public class PlatformQuery
	{
		private Func<AppQuery, AppQuery> current;

		/// <summary>Sets the query pattern for Android.</summary>
		public Func<AppQuery, AppQuery> Android
		{
			set
			{
				if (AppManager.Platform == Platform.Android)
				{
					this.current = value;
				}
			}
		}

		/// <summary>Gets the query pattern for current platform.</summary>
		public Func<AppQuery, AppQuery> Current
		{
			get
			{
				if (this.current == null)
				{
					throw new NullReferenceException("Trait not set for current platform");
				}

				return this.current;
			}
		}

		/// <summary>Sets the query pattern for iOS.</summary>
#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable SA1300 // Element should begin with upper-case letter
		public Func<AppQuery, AppQuery> iOS
#pragma warning restore SA1300 // Element should begin with upper-case letter
#pragma warning restore IDE1006 // Naming Styles
		{
			set
			{
				if (AppManager.Platform == Platform.iOS)
				{
					this.current = value;
				}
			}
		}
	}
}