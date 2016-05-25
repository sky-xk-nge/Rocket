using System;
using System.Collections.Generic;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rocket.API;
using Rocket.Core.Permissions;
using Rocket.Core.Assets;
using Rocket.API.Serialisation;

namespace Rocket.Core.Tests
{
    [TestClass]
    public class RocketPermissionsHelperTest
    {
        RocketPermissionsHelper target;

        public RocketPermissionsHelperTest()
        {
            target = new RocketPermissionsHelper(new XMLFileAsset<RocketPermissions>("Permissions.config.xml"));
        }

        [TestMethod]
        public void HasPermission()
        {
            Assert.IsFalse(target.HasPermission(TestingPlayer.GetPlayer(), "test2"));
            Assert.IsTrue(target.HasPermission(TestingPlayer.GetPlayer(), "effect")); 
            Assert.IsTrue(target.HasPermission(TestingPlayer.GetPlayer(), "effect"));


        }
    }
}
