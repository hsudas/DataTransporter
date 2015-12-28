using DataTransporter.Service;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataTransporter
{
    class Program

    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(Program));
    
        static void Main(string[] args)
        {
            log4net.Config.BasicConfigurator.Configure();

            InventoryFeedsService service = new InventoryFeedsService();
            service.TransportInventoryFeeds();
            
        }
    }
}
