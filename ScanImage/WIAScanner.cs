using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using WIA;

namespace ScanImage
{
	internal class WIAScanner
	{
		private class WIA_DPS_DOCUMENT_HANDLING_SELECT
		{
			public const uint FEEDER = 1u;

			public const uint FLATBED = 2u;
		}

		private class WIA_DPS_DOCUMENT_HANDLING_STATUS
		{
			public const uint FEED_READY = 1u;
		}

		private class WIA_PROPERTIES
		{
			public const uint WIA_RESERVED_FOR_NEW_PROPS = 1024u;

			public const uint WIA_DIP_FIRST = 2u;

			public const uint WIA_DPA_FIRST = 1026u;

			public const uint WIA_DPC_FIRST = 2050u;

			public const uint WIA_DPS_FIRST = 3074u;

			public const uint WIA_DPS_DOCUMENT_HANDLING_STATUS = 3087u;

			public const uint WIA_DPS_DOCUMENT_HANDLING_SELECT = 3088u;
		}

		private const string wiaFormatBMP = "{B96B3CAB-0728-11D3-9D7B-0000F81EF32E}";

		public static List<Image> Scan()
		{
			ICommonDialog dialog = new CommonDialogClass();
			Device device = dialog.ShowSelectDevice(WiaDeviceType.UnspecifiedDeviceType, AlwaysSelectDevice: true);
			if (device != null)
			{
				return Scan(device.DeviceID);
			}
			throw new Exception("You must select a device for scanning.");
		}

		public static List<Image> Scan(string scannerId)
		{
			List<Image> images = new List<Image>();
			bool hasMorePages = true;
			while (hasMorePages)
			{
				DeviceManager manager = new DeviceManagerClass();
				Device device = null;
				foreach (DeviceInfo info in manager.DeviceInfos)
				{
					if (info.DeviceID == scannerId)
					{
						device = info.Connect();
						break;
					}
				}
				if (device == null)
				{
					string availableDevices = "";
					foreach (DeviceInfo info2 in manager.DeviceInfos)
					{
						availableDevices = availableDevices + info2.DeviceID + "\n";
					}
					throw new Exception("Seu " + availableDevices);
				}
				Item item = device.Items[1];
				try
				{
					ICommonDialog wiaCommonDialog = new CommonDialogClass();
					ImageFile image = (ImageFile)wiaCommonDialog.ShowTransfer(item, "{B96B3CAB-0728-11D3-9D7B-0000F81EF32E}");
					string fileName = Path.GetTempFileName();
					File.Delete(fileName);
					image.SaveFile(fileName);
					images.Add(Image.FromFile(fileName));
				}
				catch (Exception exc)
				{
					throw exc;
				}
				finally
				{
					Property documentHandlingSelect = null;
					Property documentHandlingStatus = null;
					foreach (Property prop in device.Properties)
					{
						if ((long)prop.PropertyID == 3088)
						{
							documentHandlingSelect = prop;
						}
						if ((long)prop.PropertyID == 3087)
						{
							documentHandlingStatus = prop;
						}
					}
					hasMorePages = false;
					if (documentHandlingSelect != null && (Convert.ToUInt32(documentHandlingSelect) & (true ? 1u : 0u)) != 0)
					{
						hasMorePages = (Convert.ToUInt32(documentHandlingStatus) & 1) != 0;
					}
				}
			}
			return images;
		}

		public static List<string> GetDevices()
		{
			List<string> devices = new List<string>();
			DeviceManager manager = new DeviceManagerClass();
			foreach (DeviceInfo info in manager.DeviceInfos)
			{
				devices.Add(info.DeviceID);
			}
			return devices;
		}
	}
}
