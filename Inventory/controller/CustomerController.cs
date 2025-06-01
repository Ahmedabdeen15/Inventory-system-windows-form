using Inventory.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Inventory.controller
{
    internal class CustomerController
    {
        InventoryDbContext inventoryDb;
        public CustomerController(InventoryDbContext inventoryDb)
        {
            this.inventoryDb = inventoryDb;
        }

        private bool IsValidFaxNumber(string faxNumber)
        {
            return Regex.IsMatch(faxNumber, @"^\+?[0-9\s\-\(\)]{6,}$");
        }
        private bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase);
        }
        private bool IsValidUrl(string url)
        {
            string pattern = @"^(https?:\/\/)?([\w-]+\.)+[\w-]+(\/[\w- .\/?%&=]*)?$";
            return Regex.IsMatch(url, pattern, RegexOptions.IgnoreCase);
        }
        public void InsertCustomer(string name, string phone, string fax, string mobile, string email, string website)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone) ||
                string.IsNullOrEmpty(fax) || string.IsNullOrEmpty(mobile) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(website))
            {

                throw new ArgumentException("Invalid Customer details");
            }
            if (!Regex.IsMatch(mobile, @"^01\d{9}$"))
            {
                throw new ArgumentException("Please enter a valid Egyptian mobile number (01XXXXXXXXX)");
            }
            if (!Regex.IsMatch(phone, @"^0\d{8}$"))
            {
                throw new ArgumentException("Please enter a valid Egyptian phone number (02XXXXXXX)");
            }
            if (!IsValidFaxNumber(fax))
            {
                throw new ArgumentException("Please enter a valid fax number like \"+1 (123) 456-7890\"");
            }
            if (!IsValidEmail(email))
            {
                throw new ArgumentException("Please enter a valid mail");
            }
            if (!IsValidUrl(website))
            {
                throw new ArgumentException("Please enter a valid URL");
            }
            Customer customer = new Customer()
            {
                name = name,
                phone = phone,
                fax = fax,
                mobile = mobile,
                email = email,
                website = website
            };
            inventoryDb.customers.Add(customer);
            inventoryDb.SaveChanges();
        }
        public void UpdateCustomer(int id, string name, string phone, string fax, string mobile, string email, string website)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone) ||
                string.IsNullOrEmpty(fax) || string.IsNullOrEmpty(mobile) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(website))
            {

                throw new ArgumentException("Invalid Customer details");
            }
            if (!Regex.IsMatch(mobile, @"^01\d{9}$"))
            {
                throw new ArgumentException("Please enter a valid Egyptian mobile number (01XXXXXXXXX)");
            }
            if (!Regex.IsMatch(phone, @"^0\d{8}$"))
            {
                throw new ArgumentException("Please enter a valid Egyptian phone number (02XXXXXXX)");
            }
            if (!IsValidFaxNumber(fax))
            {
                throw new ArgumentException("Please enter a valid fax number like \"+1 (123) 456-7890\"");
            }
            if (!IsValidEmail(email))
            {
                throw new ArgumentException("Please enter a valid mail");
            }
            if (!IsValidUrl(website))
            {
                throw new ArgumentException("Please enter a valid URL");
            }
            Customer customer = inventoryDb.customers.Find(id);
            if (customer == null)
            {
                throw new KeyNotFoundException("customer not found");
            }
            customer.name = name;
            customer.phone = phone;
            customer.fax = fax;
            customer.mobile = mobile;
            customer.email = email;
            customer.website = website;
            inventoryDb.SaveChanges();
        }

        public List<Customer> GetCustomers()
        {
            return inventoryDb.customers.ToList();
        }
    }
}
