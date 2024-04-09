using Microsoft.EntityFrameworkCore;
using MPSecureVMS.Services;

namespace MPSecureVMS.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {
                if (context == null || context.Vendor == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // Look for any movies.
                if (context.Vendor.Any())
                {
                    return;   // DB has been seeded
                }

                context.Vendor.AddRange(
                    new Vendor
                    {
                        VendorName = "ABC Gym",
                        Contact = "John Smith",
                        Position = "Sales Manager",
                        ContactPhone = "123-456-7890",
                        ContactEmail = "john.smith@abccompany.com",
                        VendorAddress = "123 Main Street",
                        City = "Anytown",
                        State = "California",
                        ZipCode = 12345,
                        Notes = ""
                    },
                    new Vendor
                    {
                        VendorName = "XYZ Fitness",
                        Contact = "Sarah Johnson",
                        Position = "Marketing Director",
                        ContactPhone = " 987-654-3210",
                        ContactEmail = "sarah.johnson@xyzcorp.com",
                        VendorAddress = "456 Oak Avenu",
                        City = "Smallville",
                        State = "Texas",
                        ZipCode = 54321,
                        Notes = ""
                    },
                    new Vendor
                    {
                        VendorName = "DEF Industries",
                        Contact = "Michael Brown",
                        Position = "Operations Manager",
                        ContactPhone = "555-123-4567",
                        ContactEmail = "mbrown@defindustries.net",
                        VendorAddress = "789 Elm Street",
                        City = "Metropolis",
                        State = "New York",
                        ZipCode = 67890,
                        Notes = ""
                    },
                    new Vendor
                    {
                        VendorName = "LMN Enterprises",
                        Contact = "Emily Davis",
                        Position = "HR Coordinator",
                        ContactPhone = "222-333-4444",
                        ContactEmail = "emily.davis@lmnent.com",
                        VendorAddress = "101 Pine Road",
                        City = "Springfield",
                        State = "Illinois",
                        ZipCode = 54321,
                        Notes = ""
                    },
                    new Vendor
                    {
                        VendorName = "PQR Corporation",
                        Contact = "David Lee",
                        Position = "Product Manager",
                        ContactPhone = "999-888-7777",
                        ContactEmail = "david.lee@pqrcorp.com",
                        VendorAddress = "777 Cedar Lane",
                        City = "Rivertown",
                        State = "Florida",
                        ZipCode = 32198,
                        Notes = ""
                    },
                    new Vendor
                    {
                        VendorName = "Jessica Garcia",
                        Contact = "MNO Solutions",
                        Position = "Project Coordinator",
                        ContactPhone = "777-666-5555",
                        ContactEmail = "jgarcia@mnosolutions.org",
                        VendorAddress = "222 Maple Avenue",
                        City = "Lakeside",
                        State = "Michigan",
                        ZipCode = 87654,
                        Notes = ""
                    },
                    new Vendor
                    {
                        VendorName = "GHI Health",
                        Contact = "Robert Clark",
                        Position = "Finance Manager",
                        ContactPhone = "333-444-5555",
                        ContactEmail = "rclark@ghihealth.com",
                        VendorAddress = "444 Birch Street",
                        City = "Mountainview",
                        State = "Colorado",
                        ZipCode = 23456,
                        Notes = ""
                    },
                    new Vendor
                    {
                        VendorName = "UVW Corporation",
                        Contact = "Christopher Taylor",
                        Position = "Customer Service Representative",
                        ContactPhone = "888-777-6666",
                        ContactEmail = "christaylor@uvwcorp.com",
                        VendorAddress = "999 Walnut Avenue",
                        City = "Seaview",
                        State = "Washington",
                        ZipCode = 34567,
                        Notes = ""
                    },
                    new Vendor
                    {
                        VendorName = "STU Solutions",
                        Contact = "Samantha White",
                        Position = "Product Manager",
                        ContactPhone = "647-895-2155",
                        ContactEmail = "samwhite@stusolutions.com",
                        VendorAddress = "333 Pineapple Road",
                        City = "Sunnyside",
                        State = "California",
                        ZipCode = 12345,
                        Notes = ""
                    },
                    new Vendor
                    {
                        VendorName = "RST Enterprises",
                        Contact = "Jennifer Martinez",
                        Position = "Marketing Coordinator",
                        ContactPhone = "111-234-5177",
                        ContactEmail = "jmartinez@rstenterprises.org",
                        VendorAddress = "555 Orange Avenue",
                        City = "Hillside",
                        State = "New Jersey",
                        ZipCode = 56789,
                        Notes = ""
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
