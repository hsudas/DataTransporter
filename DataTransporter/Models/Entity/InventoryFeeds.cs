using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransporter.Models.Entity
{
    [Table("ROYAL.INVENTORY_FEEDS")]
    public class InventoryFeeds
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
		[MaxLength(50)]
		public string SKU { get; set; }
		[MaxLength(50)]
		public string ASIN { get; set; }
		[MaxLength(50)]
		public string Title { get; set; }
		[MaxLength(50)]
		public string Store { get; set; }
		public Nullable<decimal> Cost { get; set; }
        public Nullable<decimal> Price { get; set; }
		public int? Quantity { get; set; }
		[MaxLength(50)]
		public string Version { get; set; }
		[MaxLength(50)]
		public string CreateUser { get; set; }
		public Nullable<DateTime> PuchaseDate { get; set; }
        public Nullable<DateTime> ExpDate { get; set; }
        public Nullable<DateTime> CreateDate { get; set; }
		public int? Process { get; set; }
		[Column(TypeName="xml")]
		public string InvData {get; set;}
		public int? FulFillLatency { get; set; }
		[MaxLength(50)]
		public string ShipmentTemplate { get; set; }
		[MaxLength(250)]
		public string XmlDataPath { get; set; }
		[MaxLength(250)]
		public string XmlInventoryPath { get; set; }
		[MaxLength(250)]
		public string XmlPricePath { get; set; }
		[MaxLength(50)]
		public string FeedDataRespId { get; set; }
		[MaxLength(50)]
		public string FeedInventoryRespId { get; set; }
		[MaxLength(50)]
		public string FeedPriceRespId { get; set; }
		[MaxLength(50)]
		public string item { get; set; }
		public int? Status { get; set; }
		public Nullable<decimal> LowestPrice { get; set; }
        public Nullable<DateTime> LowestPriceDate { get; set; }
        public Nullable<decimal> CrawlerPrice { get; set; }
		public int? CrawlerQuantity { get; set; }
		public Nullable<System.DateTime> CrawlerPriceDate { get; set; }
        public int? NoAutoPrice { get; set; }
		[MaxLength(250)]
		public string ErrorDesc { get; set; }
		public int? Pack { get; set; }

        public int? TransferStatus { get; set; }
        //[DecimalPrecision(20,10)]
        //
        public InventoryFeeds()
        {
            //this.Status = 1;
            //this.CreateDate = DateTime.Now.ToString("yyyyMMddHHmmssfff");
        }

    }
}
