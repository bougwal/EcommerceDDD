﻿namespace EcommerceDDD.Shipments.Application.ProcessingShipment;

public class PackageShipped : IntegrationEvent
{
    public Guid ShipmentId { get; private set; }
    public Guid OrderId { get; private set; }
    public DateTime ShippedAt { get; private set; }

    public PackageShipped(
        Guid shipmentId,
        Guid orderId,
        DateTime shippedAt)
    {
        ShipmentId = shipmentId;
        OrderId = orderId;
        ShippedAt = shippedAt;
    }
}