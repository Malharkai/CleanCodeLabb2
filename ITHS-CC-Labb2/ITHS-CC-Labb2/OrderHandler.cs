using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITHS_CC_Labb2;
namespace ITHS_CC_Labb2
{
    public class OrderHandler
    {
        private ILogger _logger;
        private IEmailHandler _emailHandler;
        public OrderHandler(ILogger logger, IEmailHandler emailHandler)
        {
            _logger = logger;
            _emailHandler = emailHandler;
        }
        public void HandleOrder(Order order)
        {
            bool s = false;
            
            _logger.Log("Attempting to process order with ID " + order.ID);
            if (order.Priority == OrderStatus.Normal)
            {
                s = ProcessOrderNormally.Process(order);
                _logger.Log("Succesfully processed order with ID " + order.ID);
                _emailHandler.Email(order.Email, order.ID);
            }
            else if (order.Priority == OrderStatus.Quick)
            {
                s = ProcessOrderQuickly.Process(order);
                _logger.Log("Succesfully processed order with ID " + order.ID);
                _emailHandler.Email(order.Email, order.ID);
            }
            else if (order.Priority == OrderStatus.LightningSpeed)
            {
                s = ProcessOrderInLightningSpeed.Process(order);
                _logger.Log("Succesfully processed order with ID " + order.ID);
                _emailHandler.Email(order.Email, order.ID);
            }
            else
            {
                s = false;
            }

            if (!s)
            {
                _logger.Log("FAILED ORDER: Could not ship order with ID " + order.ID);
            }
        }
    }
}
