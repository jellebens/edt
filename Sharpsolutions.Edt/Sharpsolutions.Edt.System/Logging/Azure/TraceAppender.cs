﻿using log4net.Appender;
using log4net.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpsolutions.Edt.System.Logging.Azure {
    public class TraceAppender: log4net.Appender.TraceAppender {
        protected override void Append(LoggingEvent loggingEvent) {
            var level = loggingEvent.Level;

            var message = RenderLoggingEvent(loggingEvent);

            if (level >= Level.Error) {
                Trace.TraceError(message);
            } else if (level >= Level.Warn) {
                Trace.TraceWarning(message);
            } else if (level >= Level.Info) {
                Trace.TraceInformation(message);
            } else {
                Trace.Write(message);
            }

            if (ImmediateFlush) {
                Trace.Flush();
            }
        }
    }
}
