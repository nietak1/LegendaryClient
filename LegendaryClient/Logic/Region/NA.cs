﻿using System;
using System.Net;

namespace LegendaryClient.Logic.Region
{
    public sealed class NA : BaseRegion
    {
        public override string RegionName
        {
            get { return "NA"; }
        }

        public override string InternalName
        {
            get { return "NA1"; }
        }

        public override string ChatName
        {
            get { return "na1"; }
        }

        public override PVPNetConnect.Region PVPRegion
        {
            get { return PVPNetConnect.Region.NA; }
        }

        public override IPAddress[] PingAddresses
        {
            get { 
                return new IPAddress[]
                {
                    IPAddress.Parse("216.52.241.254"),
                    IPAddress.Parse("64.7.194.1"),
                    IPAddress.Parse("66.150.148.1")
                }; 
            }
        }

        public override Uri SpectatorLink
        {
            get { return new Uri("http://spectator.na.lol.riotgames.com/observer-mode/rest/featured"); }
        }

        public override Uri SpectatorIpAddress
        {
            get { return new Uri("216.133.234.17:8088"); }
        }
    }
}
