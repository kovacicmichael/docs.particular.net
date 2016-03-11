﻿using System;
using NServiceBus;

namespace Distributor
{
    internal class Program
    {
        static void Main()
        {
            #region DistributorCode

            BusConfiguration busConfiguration = new BusConfiguration();
            busConfiguration.EndpointName("Samples.Scaleout.Distributor");
            busConfiguration.RunMSMQDistributor(withWorker: false);
            busConfiguration.UseSerialization<JsonSerializer>();
            busConfiguration.UsePersistence<InMemoryPersistence>();
            busConfiguration.EnableInstallers();
            using (IBus bus = Bus.Create(busConfiguration).Start())
            {
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }

            #endregion
        }
    }
}