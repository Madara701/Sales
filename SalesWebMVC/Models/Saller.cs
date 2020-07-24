﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMVC.Models
{
    public class Saller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email  { get; set; }
        public  DateTime BirthDate  { get; set; }
        public double BaseSaraly { get; set; }
        public Department Department { get; set; }
        public ICollection<SalesRecord> SalesRecords { get; set; } = new List<SalesRecord>();

        public Saller() {
        }

        public Saller(int id, string name, string email, DateTime birthDate, double baseSaraly) {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSaraly = baseSaraly;
        }

        public void AddSales(SalesRecord sale) {

            SalesRecords.Add(sale);

        }

        public void RemoveSales(SalesRecord sale) {

            SalesRecords.Remove(sale);

        }

        public double TotalSales(DateTime initial, DateTime final) {

            return SalesRecords.Where(x => x.Date >= initial && x.Date <= final).Sum(x => x.Amount);

        }
    }
}
