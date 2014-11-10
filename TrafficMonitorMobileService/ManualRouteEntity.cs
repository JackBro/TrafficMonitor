﻿using System;

namespace TrafficMonitorMobileService
{
    /// <summary></summary>
    public class ManualRouteEntity : StorageData
    {
        /// <summary></summary>
        public string UserId { get; set; }

        /// <summary></summary>
        public DateTime StartTime { get; set; }

        /// <summary></summary>
        public DateTime EndTime { get; set; }
    }
}