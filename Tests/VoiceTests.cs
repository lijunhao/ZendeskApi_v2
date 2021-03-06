﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ZendeskApi_v2;

namespace Tests
{
    [TestFixture]
    [Category("Voice")]
    public class VoiceTests
    {
        private ZendeskApi api = new ZendeskApi(Settings.Site, Settings.Email, Settings.Password);
        private long agentid;
        private long ticketid;
        private long userid;

        [Test]
        public void OpenTicketForAgent()
        {
            agentid = Settings.UserId;
            ticketid = Settings.SampleTicketId;

            var result = api.Voice.OpenTicketInAgentBrowser(agentid, ticketid);
            Assert.IsTrue(result);
        }

        [Test]
        public void OpenTicketTabForAgentAsync()
        {
            agentid = Settings.UserId;
            ticketid = Settings.SampleTicketId;

            var result = api.Voice.OpenTicketInAgentBrowserAsync(agentid, ticketid);
            Assert.IsTrue(result.Result);
        }

        [Test]
        public void OpenUserProfileInAgentBrowser()
        {
            agentid = Settings.UserId;
            userid = Settings.EndUserId;

            var result = api.Voice.OpenUserProfileInAgentBrowser(agentid, userid);
            Assert.IsTrue(result);
        }

        [Test]
        public void OpenUserProfileInAgentBrowserAsync()
        {
            agentid = Settings.UserId;
            userid = Settings.EndUserId;

            var result = api.Voice.OpenUserProfileInAgentBrowserAsync(agentid, userid);
            Assert.IsTrue(result.Result);
        }

    }
}
