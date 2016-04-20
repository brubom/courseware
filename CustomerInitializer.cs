using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Albumprinter.Customers.WebRestService.Domain;

namespace Albumprinter.Customers.WebRestService.DAL
{
    public class CustomerInitializer : IDatabaseInitializer<CustomerContext>
    {
        #region Overrides of DropCreateDatabaseIfModelChanges<CustomerContext>

        /// <summary>
        /// A method that should be overridden to actually add data to the context for seeding.
        ///             The default implementation does nothing.
        /// </summary>
        /// <param name="context">The context to seed. </param>
        protected void Seed(CustomerContext context)
        {
            
            var customers = new List<Customer>
            {
                new Customer
                {
                    Email = "teobaldo@fakemail.com",
                    Name = "Teobaldo Monteforte",
                    Orders =
                        new List<Order>
                        {
                            new Order {CreatedDate = DateTime.Now, Price = 1.1M},
                            new Order {CreatedDate = DateTime.Now, Price = 2.1M},
                            new Order {CreatedDate = DateTime.Now, Price = 3.1M}
                        }
                },
                new Customer
                {
                    Email = "bruno@fakemail.com",
                    Name = "Bruno Moreira",
                    Orders =
                        new List<Order>
                        {
                            new Order {CreatedDate = DateTime.Now, Price = 4.1M},
                            new Order {CreatedDate = DateTime.Now, Price = 5.1M},
                            new Order {CreatedDate = DateTime.Now, Price = 6.1M}
                        }
                },
                new Customer
                {
                    Email = "cido@fakemail.com",
                    Name = "Cido Ferreira",
                    Orders =
                        new List<Order>
                        {
                            new Order {CreatedDate = DateTime.Now, Price = 7.1M},
                            new Order {CreatedDate = DateTime.Now, Price = 8.1M},
                            new Order {CreatedDate = DateTime.Now, Price = 9.1M}
                        }
                }
            };

            customers.ForEach(c => context.Customers.Add(c));
            context.SaveChanges();


        }

        #endregion

        #region Implementation of IDatabaseInitializer<in CustomerContext>

        /// <summary>
        /// Executes the strategy to initialize the database for the given context.
        /// </summary>
        /// <param name="context">The context. </param>
        public void InitializeDatabase(CustomerContext context)
        {
            if (!context.Customers.Any())
                this.Seed(context);
        }

        #endregion
    }
}
