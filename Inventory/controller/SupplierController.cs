using Inventory.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Inventory.controller
{
    internal class SupplierController
    {
        InventoryDbContext inventoryDb;
        public SupplierController(InventoryDbContext inventoryDb)
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
        public void InsertSupplier(string name , string phone , string fax , string mobile , string email, string website)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone) ||
                string.IsNullOrEmpty(fax) || string.IsNullOrEmpty(mobile) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(website)) {

                throw new ArgumentException("Invalid Supplier details");
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
            Supplier supplier = new Supplier() { 
            name = name,
            phone = phone,
            fax = fax,
            mobile = mobile,
            email = email,
            website = website
            };
            inventoryDb.suppliers.Add(supplier);
            inventoryDb.SaveChanges();
        }
        public void UpdateSupplier(int id , string name, string phone, string fax, string mobile, string email, string website)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone) ||
                string.IsNullOrEmpty(fax) || string.IsNullOrEmpty(mobile) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(website))
            {

                throw new ArgumentException("Invalid Supplier details");
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
            Supplier supplier = inventoryDb.suppliers.Find(id);
            if (supplier == null) {
                throw new KeyNotFoundException("Supplier not found");
            }
            supplier.name = name;
            supplier.phone = phone;
            supplier.fax = fax;
            supplier.mobile = mobile;
            supplier.email = email;
            supplier.website = website;
            inventoryDb.SaveChanges();
        }

        public List<Supplier> GetSuppliers() { 
            return inventoryDb.suppliers.ToList();
        }
    }
}
