using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TerminalApp.Models.Entities;

namespace TerminalApp.Models
{
    public  class PozitionByQuadrant
    {
        public  string PozitionNameByQuadrant { get; set; }
        public  int SkuIdByQuadrant { get; set; }
        public string Availability { get; set; }
    }
    public class DataTakenFromClient
    {
        public static int UserCode { get; set; }
        public static string Quadrant { get; set; }
        public static int OrderId { get; set; }
        public static int ConteynerId { get; set; }
        public static string PozitionName { get; set; }
        public static int TerminalCode { get; set; }
        public static List<Order> ListByQuadrant { get; set; }
        public static List<Order> ClothesOrderByQuadrant { get; set; }
        public static List<Order> ShoesOrderByQuadrant { get; set; }
        public static List<Order> JeweleriesOrderByQuadrant { get; set; }
        public static List<Pozition> PozitionsByQuadrant { get; set; }
        public static List<PozitionByQuadrant> PozitionByQuadrantList { get; set; }
        public static int SkuTypeId { get; set; }

    }
   
}
