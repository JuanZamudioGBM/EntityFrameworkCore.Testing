﻿using EntityFrameworkCore.Testing.Common.Tests;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace EntityFrameworkCore.Testing.NSubstitute.Tests
{
    public class ByPropertyDbQueryExceptionTests : ReadOnlyDbSetExceptionTests<ViewEntity>
    {
        [SetUp]
        public override void SetUp()
        {
            base.SetUp();

            MockedDbContext = Create.MockedDbContextFor<TestDbContext>();
        }

        protected TestDbContext MockedDbContext;

        protected override DbSet<ViewEntity> DbSet => MockedDbContext.ViewEntities;
    }
}