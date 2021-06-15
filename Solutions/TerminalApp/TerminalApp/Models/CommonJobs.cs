using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TerminalApp.Models;

namespace TerminalApp.Models
{
    public class CommonJobs
    {

        Models.Entities.LogisticDataBaseEntities1 db = new Models.Entities.LogisticDataBaseEntities1();
        public  string message { get; set; }
        public void PickingJob(int Sku1)
        {
            try
            {

                var skuCheck = db.Sku.Where(x => x.Sku1 == Sku1).FirstOrDefault();
                if (skuCheck != null)
                {
                    var pozitionSkuCheck = db.Pozition.Where(x => x.SkuId == skuCheck.Id).FirstOrDefault();
                    if (pozitionSkuCheck != null)
                    {
                        var skuPiece = pozitionSkuCheck.SkuPiece;
                        skuPiece = skuPiece - 1;
                        pozitionSkuCheck.SkuPiece = skuPiece;
                        skuCheck.SkuPiece = skuPiece;

                        if (pozitionSkuCheck.SkuPiece == 0)
                        {
                            pozitionSkuCheck.Availability = "True";
                            pozitionSkuCheck.SkuId = null;

                        }
                        db.SaveChanges();
                    }
                    else message = "Sku Belirtilen Pozisyonda Bulunamadı !";
                }
                else message = "Geçersiz Sku";
            }
            catch (Exception)
            {

                message = "Hata Oluştu !";
            }
        }

        public void WorkAdd(int Sku, string PozitionName, string workType, string workName,string Quadrant,int userCode,int TerminalCode)
        {
            
            var workCount = db.Work.Count();
            var work = new Models.Entities.Work();
            work.Id = workCount + 1;
            work.WorkType = workType;
            work.WorkName = workName;
            work.UserCode = userCode;
            work.TerminalCode = TerminalCode;
            work.WorkDate = DateTime.Now.Date;
            work.Quadrant = Quadrant;
            work.Sku = Sku;
            work.Pozition = PozitionName;
            db.Work.Add(work);
            db.SaveChanges();
        }

        public void TransferAdd(string TransferType,DateTime TransferDate,int OrderId)
        {
            var workCount = db.Work.Count();
            var transferCount = db.Transfer.Count();
            var transfer = new Models.Entities.Transfer();
            transfer.Id = transferCount + 1;
            transfer.TransferType = TransferType;
            transfer.TransferStartDate = TransferDate;
            transfer.TransferStatus = "Waiting";
            transfer.OrderId = OrderId;
            transfer.WorkId = workCount + 1;

            db.Transfer.Add(transfer);
            db.SaveChanges();
        }
        public void ChangeOrderStatus(int sku)
        {            
            var order = Models.DataTakenFromClient.ListByQuadrant.Where(x => x.OrderSku == sku).FirstOrDefault();
            order.OrderStatus = "Packing";
            db.SaveChanges();
        }
    }
}