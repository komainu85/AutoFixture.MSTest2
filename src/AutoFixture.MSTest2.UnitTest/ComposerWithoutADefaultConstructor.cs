﻿using System;
using Ploeh.AutoFixture.Kernel;

namespace Ploeh.AutoFixture.MSTest2.UnitTest
{
    internal class ComposerWithoutADefaultConstructor : DelegatingFixture
    {
        public ComposerWithoutADefaultConstructor(Func<ISpecimenBuilder> onCompose)
        {
            if (onCompose == null)
                throw new ArgumentNullException("onCompose");
        }
    }
}
