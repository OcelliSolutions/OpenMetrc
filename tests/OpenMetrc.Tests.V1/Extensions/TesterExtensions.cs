using System;
using System.Threading;

namespace OpenMetrc.Tests.V1.Extensions;

public static class TesterExtensions
{
    public static T TryNTimes<T>(Func<T> func, int times)
    {
        while (times > 0)
            try
            {
                return func();
            }
            catch (Exception)
            {
                if (--times <= 0)
                    throw;
                var random = new Random();
                var milliseconds = random.Next(3, 10) * 1000;
                Thread.Sleep(milliseconds);
            }

        throw new InvalidOperationException("Nothing returned");
    }
}