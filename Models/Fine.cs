﻿using FineCar.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace FineCar.Models
{
    public class Fine
    {


        public int Id { get; set; }


        //[EstonianCarNumber(ErrorMessage = "Введите правильный номер автомобиля в формате ABC-123.")] public string CarNumber { get; set; }
        //[EstonianCarNumber()]
        //public string CarNumber { get; set; }
        //public string Name { get; set; }
        //public string Email { get; set; }



        //[EstonianPhoneNumber()]

        //public string PhoneNumber { get; set; }
        public DateTime dateTime { get; set; }
        public int Excess { get; set; }
        public int Amount { get; set; }


        public int UserId { get; set; }
    }
}