﻿/*
 * (c) 2008 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 */

using System;
using System.Reflection;
using Mosa.ClassLib;

namespace Mosa.DeviceDrivers.PCI
{
	public class PCIRegistry
	{
		PlatformArchitecture platformArchitecture;

		protected LinkedList<Pair<PCIDeviceSignatureAttribute, Type>> drivers;

		public PCIRegistry(PlatformArchitecture platformArchitecture)
		{
			this.platformArchitecture = platformArchitecture;
			drivers = new LinkedList<Pair<PCIDeviceSignatureAttribute, Type>>();
		}

		public void AddDeviceDriver(PCIDeviceSignatureAttribute deviceDriverSignature, Type type)
		{
			drivers.Add(new Pair<PCIDeviceSignatureAttribute, Type>(deviceDriverSignature, type));
		}

		public PCIHardwareDevice CreateDevice(PCIDevice pciDevice)
		{
			Type deviceType = FindDriver(pciDevice);

			if (deviceType == null)
				return null;

			return Activator.CreateInstance(deviceType, pciDevice) as PCIHardwareDevice;
		}

		public Type FindDriver(PCIDevice pciDevice)
		{
			Type deviceType = null;
			int bestPriority = Int32.MaxValue;

			foreach (Pair<PCIDeviceSignatureAttribute, Type> entry in drivers) {
				if ((entry.First.Priority != 0) && (entry.First.Priority < bestPriority)) {
					if (entry.First.CompareTo(pciDevice)) {
						deviceType = entry.Second;
						bestPriority = entry.First.Priority;
					}
				}
			}

			return deviceType;
		}

		public void RegisterBuildInDeviceDrivers()
		{
			Assembly assemblyInfo = typeof(PCIRegistry).Module.Assembly;
			RegisterDeviceDrivers(assemblyInfo);
		}

		public void RegisterDeviceDrivers(Assembly assemblyInfo)
		{
			Type[] types = assemblyInfo.GetTypes();

			foreach (Type type in types) {
				object[] attributes = type.GetCustomAttributes(typeof(PCIDeviceSignatureAttribute), false);

				foreach (object attribute in attributes)
					if (((attribute as PCIDeviceSignatureAttribute).Platforms & platformArchitecture) != 0)
						AddDeviceDriver(attribute as PCIDeviceSignatureAttribute, type);
			}
		}

		public void StartDrivers(IDeviceManager deviceManager, IResourceManager resourceManager)
		{
			foreach (IDevice device in deviceManager.GetDevices(new FindDevice.IsPCIDevice(), new FindDevice.IsAvailable())) {
				PCIDevice pciDevice = device as PCIDevice;
				PCIHardwareDevice pciHardwareDevice = CreateDevice(pciDevice);
				if (pciHardwareDevice != null)
					pciDevice.Start(deviceManager, resourceManager, pciHardwareDevice);
				else
					pciDevice.SetNoDriverFound();
			}
		}
	}
}