﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Minutes
{
	public partial class App : Application
	{
		public static INoteEntryStore Entries { get; set; }

		public App ()
		{
			InitializeComponent();

            Entries = new FileEntryStore(); // new MemoryEntryStore();
            //Entries.LoadMockData();

            MainPage = new NavigationPage(new EntriesPage());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}