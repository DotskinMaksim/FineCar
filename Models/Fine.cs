using FineCar.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FineCar.Models
{
    public class Fine
    {


        public int Id { get; set; }


        [EstonianCarNumber(ErrorMessage = "Введите правильный номер автомобиля в формате ABC-123.")] public string CarNumber { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime dateTime { get; set; }
        [DataType(DataType.DateTime, ErrorMessage ="Ainult Kuupäev")]
        [DisplayFormat(DataFormatString = "{0:G}", ApplyFormatInEditMode = true)]
        public int Excess { get; set; }
        public int Amount { get; set; }
    }
}