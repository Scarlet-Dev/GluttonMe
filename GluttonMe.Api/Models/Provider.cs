using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GluttonMe.Api.Models
{
    public class Provider
    {
        public Address Address { get; set; }

        public Menu Menu { get; set; }

        public string[] Speciality { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime OpeningHours { get; set; }

        public DateTime ClosingHours { get; set; }

        public Days DaysOpened { get; set; }

        public string ImagePath { get; set; }
    }

    public struct Menu
    {
        public int ItemId { get; set; }

        public string ItemName { get; set; }

        public MenuItemType ItemType { get; set; }

        public string ItemDescription { get; set; }

        public decimal ItemPrice { get; set; }

        public string ItemImagePath { get; set; }
    }

    public struct Address
    {
        public string Street { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }
    }

    public enum MenuItemType
    {
        Vegetarian = 0,
        Soup,
        Salad,
        Appetizers,


    }

    public enum Days
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
}
