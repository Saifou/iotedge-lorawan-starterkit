// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace LoRaWan.NetworkServer
{
    using System.Text;
    using System.Threading.Tasks;
    using LoRaTools;

    public interface ILoRaCloudToDeviceMessage
    {
        string DevEUI { get; }

        byte Fport { get; }

        bool Confirmed { get; }

        string MessageId { get; }

        byte[] GetPayload();

        Task<bool> CompleteAsync();

        Task<bool> AbandonAsync();

        MacCommandHolder GetMacCommands();
    }
}