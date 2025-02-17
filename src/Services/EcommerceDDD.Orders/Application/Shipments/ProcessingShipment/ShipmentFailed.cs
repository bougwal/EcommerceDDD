﻿namespace EcommerceDDD.Orders.Application.Shipments.ProcessingShipment;

public class ShipmentFailed : IntegrationEvent
{
    public Guid ShippingId { get; }
    public Guid OrderId { get; }
    public DateTime FailedAt { get; }

    public ShipmentFailed(
        Guid shippingId, 
        Guid orderId)
    {
        ShippingId = shippingId;
        OrderId = orderId;
        FailedAt = DateTime.UtcNow;
    }
}
