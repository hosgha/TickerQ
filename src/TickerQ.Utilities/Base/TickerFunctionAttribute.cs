using System;
using TickerQ.Utilities.Enums;

namespace TickerQ.Utilities.Base
{
    [AttributeUsage(AttributeTargets.Method)]
    public class TickerFunctionAttribute : Attribute
    {
        /// <summary>
        /// Cron-based ticker job (in 6-field format).
        /// </summary>
        /// <param name="functionName">Unique job name.</param>
        /// <param name="cronExpression">
        /// Cron expression in 6-field format: "second minute hour day month dayOfWeek".
        /// </param>
        /// <param name="taskPriority">Job priority (default Normal).</param>
        public TickerFunctionAttribute(string functionName, string cronExpression = null,
            TickerTaskPriority taskPriority = TickerTaskPriority.Normal) { }

        /// <summary>
        /// Time-based ticker job. Requires <see cref="TickerType.TimeTicker"/> to avoid conflict with cron overload.
        /// </summary>
        /// <remarks>
        /// Use <see cref="TickerType.TimeTicker"/> when specifying an absolute execution time.
        /// Cron jobs must use the cron-based constructor instead.
        /// </remarks>
        /// <param name="functionName">Unique job name.</param>
        /// <param name="tickerType">Must be <see cref="TickerType.TimeTicker"/>.</param>
        /// <param name="executionTime">ISO-8601 time (e.g. "2025-11-30T09:00:00Z").</param>
        /// <param name="timeZone">Time zone (default UTC).</param>
        /// <param name="taskPriority">Job priority (default Normal).</param>
        public TickerFunctionAttribute(string functionName, TickerType tickerType, string executionTime = null,
            string timeZone = "UTC", TickerTaskPriority taskPriority = TickerTaskPriority.Normal) { }

        /// <summary>
        /// Lightweight job with only name and priority.
        /// </summary>
        public TickerFunctionAttribute(string functionName, TickerTaskPriority taskPriority) { }

        /// <summary>
        /// Absolute date/time job using split fields.
        /// </summary>
        public TickerFunctionAttribute(string functionName, int year, int month, int day, int hour, int minute,
            int second, TickerTaskPriority taskPriority = TickerTaskPriority.Normal) { }

        /// <summary>
        /// Offset-based job (runs after N seconds).
        /// </summary>
        public TickerFunctionAttribute(string functionName, int offsetSeconds,
            TickerTaskPriority taskPriority = TickerTaskPriority.Normal) { }
    }
}
