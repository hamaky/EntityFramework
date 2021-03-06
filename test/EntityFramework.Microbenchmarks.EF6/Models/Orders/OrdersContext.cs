// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using EntityFramework.Microbenchmarks.Core.Models.Orders;
using System.Data.Entity;

namespace EntityFramework.Microbenchmarks.EF6.Models.Orders
{
    public class OrdersContext : DbContext
    {
        public OrdersContext(string connectionString)
            : base(connectionString)
        { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
