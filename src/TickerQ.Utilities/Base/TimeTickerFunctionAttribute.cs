using System;
using TickerQ.Utilities.Enums;

namespace TickerQ.Utilities.Base;

[AttributeUsage(AttributeTargets.Method)]
public class TimeTickerFunctionAttribute : Attribute
{
    /// <summary>
    /// Schedules a time-based ticker job to run at an exact moment.
    /// </summary>
    /// <param name="functionName">A unique identifier for the job.</param>
    /// <param name="executionTime">
    /// The execution timestamp in ISO-8601 format 
    /// (e.g. "2025-11-30T09:00:00Z").
    /// </param>
    /// <param name="timeZone">
    /// The time zone for the execution time. Defaults to <c>UTC</c>.
    /// </param>
    /// <param name="taskPriority">
    /// Priority of the job. Defaults to <see cref="TickerTaskPriority.Normal"/>.
    /// </param>
    public TimeTickerFunctionAttribute(
        string functionName,
        string executionTime,
        string timeZone = "UTC",
        TickerTaskPriority taskPriority = TickerTaskPriority.Normal)
    {
    }

    /// <summary>
    /// Schedules a job using explicit date and time components.
    /// </summary>
    /// <param name="functionName">A unique identifier for the job.</param>
    /// <param name="year">The year of the scheduled execution.</param>
    /// <param name="month">The month of the scheduled execution (1–12).</param>
    /// <param name="day">The day of the month (1–31).</param>
    /// <param name="hour">The hour of the day (0–23).</param>
    /// <param name="minute">The minute of the hour (0–59).</param>
    /// <param name="second">The second of the minute (0–59).</param>
    /// <param name="taskPriority">
    /// Priority of the job. Defaults to <see cref="TickerTaskPriority.Normal"/>.
    /// </param>
    public TimeTickerFunctionAttribute(
        string functionName,
        int year,
        int month,
        int day,
        int hour,
        int minute,
        int second,
        TickerTaskPriority taskPriority = TickerTaskPriority.Normal)
    {
    }

    /// <summary>
    /// Schedules an offset-based job that executes after a specified number of seconds.
    /// </summary>
    /// <param name="functionName">A unique identifier for the job.</param>
    /// <param name="offsetSeconds">Time delay before execution, in seconds.</param>
    /// <param name="taskPriority">
    /// Priority of the job. Defaults to <see cref="TickerTaskPriority.Normal"/>.
    /// </param>
    public TimeTickerFunctionAttribute(
        string functionName,
        int offsetSeconds,
        TickerTaskPriority taskPriority = TickerTaskPriority.Normal)
    {
    }
}