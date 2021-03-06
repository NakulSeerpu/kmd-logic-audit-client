﻿using System;

namespace Kmd.Logic.Audit.Client.SerilogAzureEventHubs
{
    public class SerilogAzureEventHubsAuditClientConfiguration
    {
        /// <summary>
        /// Gets or sets a value that will be tagged on every event to make
        /// it clear what the source of the event was.
        /// </summary>
        public string EventSource { get; set; }

        /// <summary>
        /// Gets or sets the Azure EventHubs connection string.
        /// </summary>
        public string ConnectionString { get; set; }

        /// <summary>
        /// Gets or sets the the topic where audit events are ingested on Azure EventHubs.
        /// Normally just leave this as the default value of "audit".
        /// </summary>
        public string AuditEventTopic { get; set; } = "audit";

        public bool? EnrichFromLogContext { get; set; }
    }
}
