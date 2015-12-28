using DataTransporter.Models.Context;
using DataTransporter.Models.Entity;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataTransporter.Service
{
    public class InventoryFeedsService
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(InventoryFeedsService));
        public void TransportInventoryFeeds()
        {
            logger.Debug("Process for InventoryFeeds is succeded.");
            while (true)
            {
                try
                {
                    //System.Threading.Thread.Sleep(10000);
                    DTFromContext dbContext = new DTFromContext();

                    var InventoryFeedsList = dbContext.InventoryFeeds.
                    Where(t => t.TransferStatus == 1).Take(10);

                    foreach (InventoryFeeds item in InventoryFeedsList)
                    {
                        item.TransferStatus = 1;
                        logger.Debug(item.SKU + " is created by " + item.CreateUser + " in " + item.CreateDate.ToString());
                    }

                    DTToContext dbContext2 = new DTToContext();
                    dbContext2.InventoryFeeds.AddRange(InventoryFeedsList);
                    dbContext.SaveChanges();
                    dbContext2.SaveChanges();
                    dbContext.Dispose();
                    dbContext2.Dispose();
                    logger.Debug("Process for InventoryFeeds is succeded.");
                }
                catch (Exception exc)
                {
                    logger.Error("TransportInventoryFeeds received an error. Error : ", exc);
                    throw exc;
                }
            }
        }
    }
}
