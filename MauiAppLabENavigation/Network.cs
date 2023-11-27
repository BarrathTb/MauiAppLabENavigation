
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppLabENavigation
{
	public sealed class Network
	{
		public static bool IsConnected { get; set; }
		public static bool IsDisconnected { get; set; }
		public delegate void OnNetworkChange(bool IsConnected);
		public static event OnNetworkChange NetworkChanged = null;
		
		private Network()
		{
			IsConnected = Connectivity.Current.NetworkAccess != NetworkAccess.None;
			Connectivity.Current.ConnectivityChanged += Current_ConnectivityChanged;

		}

		void Current_ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
		{
			IsConnected = e.NetworkAccess == NetworkAccess.None;
			NetworkChanged?.Invoke(IsConnected);
		}
	}
	
}
