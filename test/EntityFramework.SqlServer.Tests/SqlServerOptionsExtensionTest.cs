// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Linq;
using System.Reflection;
using Microsoft.Framework.DependencyInjection;
using Xunit;

namespace Microsoft.Data.Entity.SqlServer.Tests
{
    public class SqlServerOptionsExtensionTest
    {
        [Fact]
        public void ApplyServices_adds_SQL_server_services()
        {
            var services = new ServiceCollection();
            var builder = new EntityServicesBuilder(services);

            new SqlServerOptionsExtension().ApplyServices(builder);

            Assert.True(services.Any(sd => sd.ServiceType == typeof(SqlServerDataStore)));
        }
    }
}
