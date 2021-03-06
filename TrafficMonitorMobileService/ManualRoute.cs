﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrafficMonitorMobileService
{
    /// <summary>
    /// Data Transfer Object (DTO) for entities in the ManualRoute table
    /// </summary>
    public class ManualRoute
    {
        /// <summary></summary>
        public string EndPointsId { get; set; }

        /// <summary></summary>
        public DateTime StartTime { get; set; }

        /// <summary></summary>
        public DateTime EndTime { get; set; }
    }
}