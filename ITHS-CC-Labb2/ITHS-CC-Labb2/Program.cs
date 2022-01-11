using ITHS_CC_Labb2;
using System;

Logger logger = new();
EmailHandler emailHandler = new(logger);
OrderHandler orderHandler = new OrderHandler(logger,emailHandler);

Order slowOrder = new Order
{
    ID = Guid.NewGuid(),
    Email = "slowEmail@example.com",
    Priority = OrderStatus.LightningSpeed,
    TotalPrce = 100,
};
orderHandler.HandleOrder(slowOrder);