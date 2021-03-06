﻿using AutomaticTelephoneStation.ATSEquipment;
using AutomaticTelephoneStation.ATSManagment;
using System;

namespace AutomaticTelephoneStation.ClientsInfo
{
    public interface IContract
    {
        Guid ContractNumber { get; }

        DateTime DateOfContract { get; }

        IPassport Passport { get; }

        string PhoneNumber { get; }

        ITariff Tariff { get; }

        IEquipment Equipment { get; }
    }
}
