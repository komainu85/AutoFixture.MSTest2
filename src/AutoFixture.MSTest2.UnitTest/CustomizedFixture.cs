﻿using Ploeh.TestTypeFoundation;

namespace Ploeh.AutoFixture.MSTest2.UnitTest
{
    internal class CustomizedFixture : Fixture
    {
        public CustomizedFixture()
        {
            this.Customize<PropertyHolder<string>>(c => c.With(x => x.Property, "Ploeh"));
        }
    }
}