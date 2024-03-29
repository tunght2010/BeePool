﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datn_Shared.ViewModels.ProductDetailViewModels
{
    public class CreateProductDetail
    {
        public Guid Id { get; set; }
        public Guid ProductID { get; set; }
        public Guid ShaftId { get; set; }
        public Guid WeightId { get; set; }
        public Guid TipId { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập quantity")]
        public int Quantity { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập Importprice")]
        public double ImportPrice { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập price")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập createdate")]
        public DateTime CreateDate { get; set; }
        public List< string> Image { get; set; }

        public int Status { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập description")]
        public string Description { get; set; }
    }
}
