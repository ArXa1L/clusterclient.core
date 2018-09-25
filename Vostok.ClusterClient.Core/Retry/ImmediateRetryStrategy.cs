﻿using System;

namespace Vostok.ClusterClient.Core.Retry
{
    /// <summary>
    /// Represents a retry strategy with fixed attempts count and a zero delay between attempts.
    /// </summary>
    public class ImmediateRetryStrategy : IRetryStrategy
    {
        /// <param name="attemptsCount">Maximum attempts count.</param>
        public ImmediateRetryStrategy(int attemptsCount)
        {
            AttemptsCount = attemptsCount;
        }

        /// <summary>
        /// Maximum attempts count.
        /// </summary>
        public int AttemptsCount { get; }

        /// <inheritdoc />
        public TimeSpan GetRetryDelay(int attemptsUsed) => TimeSpan.Zero;
    }
}