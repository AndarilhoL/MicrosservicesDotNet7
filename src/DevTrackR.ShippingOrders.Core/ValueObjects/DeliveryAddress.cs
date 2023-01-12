using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevTrackR.ShippingOrders.Core.ValueObjects
{
    public record DeliveryAddress(string Street, string Number, string ZipCode, string City, string State, string Country)
    {
        
    }
}