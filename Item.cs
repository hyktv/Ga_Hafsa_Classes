using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ga_Hafsa_Classes
{
    public class Item
    {
        //feilds
        string _name;
        string _description;
        double _price;
        double _discount;

        //contructor
        public Item(string name, string description, double price, double discount)
        {
            _name = name;
            _description = description;
            _price = price;
            _discount = discount;

        } //item

        public Item(string name, double price)
        {
            _name = name;
            _price = price;
            _discount = 0;
            _description = "";

        } //item

        //properties
        public string Name
        {
            get 
            { 
                return _name; 
            }
            set 
            {
                _name = value; 
            }

        } //name

        public string Description
        {
            get
            { 
                return _description; 
            }
            set
            { 
                _description = value; 
            }

        }

        public double Price
        {
            get 
            { 
                return _price; 
            }
            set
            {
                //validating that value is not a negative
                if(value <= 0)
                {
                    _price = value;
                }
            }
        } //price

        public double Discount
        {
            get 
            { 
                return _discount; 
            }
            set
            {
                //validating that the value is not negative or over 100 percent
                if(value >= 0 && value <= 1)
                {
                    _discount = value;
                }
            }
        } //discount
        
        public double DiscountedAmount()
        {
            return Price * Discount;
        } //DiscountedAmount

        public double CalculateTotalPrice()
        {
            return Price - DiscountedAmount();
        } //CalculateTotalPrice

        public override string ToString()
        {
            return $"Name: {_name} - Price: {_price.ToString("c")} - Discount: {_discount.ToString("c")} - Total Price: {_price.ToString("c")}";
        } //ToString


    }//class

}
