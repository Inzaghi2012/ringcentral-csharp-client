﻿using Xunit;
using System.Linq;

namespace RingCentral.Test
{
    [Collection("RestClient collection")]
    public class ServiceInfoTest
    {
        private RestClient rc;
        public ServiceInfoTest(RestClientFixture fixture)
        {
            rc = fixture.rc;
        }

        [Fact]
        public void ServiceInfo()
        {
            // account service-info
            var account = rc.Restapi().Account();
            var accountServiceInfo = account.ServiceInfo().Get<ServiceInfo.AccountServiceInfo>().Result;
            var faxReceiving = accountServiceInfo.serviceFeatures.First(item => item.featureName == "FaxReceiving").enabled;
            Assert.True(faxReceiving);

            // meeting service-info
            // todo: meeting api is not yet ready, so I cannot test it right now
        }
    }
}