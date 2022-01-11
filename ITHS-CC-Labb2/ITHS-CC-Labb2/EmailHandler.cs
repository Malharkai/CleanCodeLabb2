using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHS_CC_Labb2
{
    public class EmailHandler : IEmailHandler
    {
        private ILogger _logger;
        public EmailHandler(ILogger logger)
        {
            _logger = logger;
        }
        public void Email(string email, Guid ID)
        {
            // Some email sending logic we don't care about
            _logger.Log($"Notification sent to email {email} for order {ID}");
        }
    }
}
