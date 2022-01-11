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
            bool isSuccesful = false;

            _logger.Log("Attempting to process order with ID " + order.ID);
            isSuccesful = order.Processor.Process(order);
            _emailHandler.Email(order.Email, order.ID);


            if (!isSuccesful)
            {
                _logger.Log("FAILED ORDER: Could not ship order with ID " + order.ID);
            }
            else
            {
                _logger.Log("Succesfully processed order with ID " + order.ID);
            }
        }
    }
}
