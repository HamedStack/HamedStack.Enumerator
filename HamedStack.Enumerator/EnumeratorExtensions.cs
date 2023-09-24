// ReSharper disable CheckNamespace
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedType.Global
// ReSharper disable ConvertIfStatementToSwitchStatement

using System.Diagnostics.CodeAnalysis;

/// <summary>
/// Provides extension methods for the <see cref="IEnumerator&lt;T&gt;"/> and <see cref="IAsyncEnumerator&lt;T&gt;"/> types .
/// </summary>
[SuppressMessage("Design", "CA1050:Declare types in namespaces")]
public static class HamedStackEnumeratorExtensions
{
    /// <summary>
    /// Returns the same enumerator for the given type.
    /// </summary>
    /// <typeparam name="T">The type of items in the enumerator.</typeparam>
    /// <param name="enumerator">The enumerator to return.</param>
    /// <returns>The input enumerator.</returns>
    public static IEnumerator<T> GetEnumerator<T>(this IEnumerator<T> enumerator) => enumerator;

    /// <summary>
    /// Returns the same asynchronous enumerator for the given type.
    /// </summary>
    /// <typeparam name="T">The type of items in the asynchronous enumerator.</typeparam>
    /// <param name="enumerator">The asynchronous enumerator to return.</param>
    /// <returns>The input asynchronous enumerator.</returns>
    public static IAsyncEnumerator<T> GetAsyncEnumerator<T>(this IAsyncEnumerator<T> enumerator) => enumerator;

    /// <summary>
    /// Produces an enumerator that yields integers starting from 0 up to the given input if it is positive, or starting from the input up to 0 if it is negative.
    /// </summary>
    /// <param name="input">The input int value.</param>
    /// <returns>An enumerator of integers.</returns>
    public static IEnumerator<int> GetEnumerator(this int input)
    {
        if (input == 0)
        {
            yield return 0;
        }
        else if (input > 0)
        {
            for (var i = 0; i <= input; i++)
            {
                yield return i;
            }
        }
        else
        {
            for (var i = 0; i >= input; i--)
            {
                yield return i;
            }
        }
    }

    /// <summary>
    /// Produces an enumerator that yields longs starting from 0 up to the given input if it is positive, or starting from the input up to 0 if it is negative.
    /// </summary>
    /// <param name="input">The input long value.</param>
    /// <returns>An enumerator of longs.</returns>
    public static IEnumerator<long> GetEnumerator(this long input)
    {
        if (input == 0)
        {
            yield return 0;
        }
        else if (input > 0)
        {
            for (var i = 0; i <= input; i++)
            {
                yield return i;
            }
        }
        else
        {
            for (var i = 0; i >= input; i--)
            {
                yield return i;
            }
        }
    }

    /// <summary>
    /// Produces an enumerator that yields integers between the provided range.
    /// </summary>
    /// <param name="range">The tuple containing the start and end values of the range.</param>
    /// <returns>An enumerator of integers.</returns>
    public static IEnumerator<int> GetEnumerator(this (int from, int to) range)
    {
        if (range.from > range.to)
        {
            throw new ArgumentException("Start value (from) cannot be greater than end value (to).");
        }
        for (var i = range.from; i < range.to; i++)
        {
            yield return i;
        }
    }

    /// <summary>
    /// Produces an enumerator that yields integers between the provided range, advancing by the specified step.
    /// </summary>
    /// <param name="range">The tuple containing the start and end values of the range and the step value for each iteration.</param>
    /// <returns>An enumerator of integers.</returns>
    public static IEnumerator<int> GetEnumerator(this (int from, int to, int step) range)
    {
        if (range.step == 0)
        {
            throw new ArgumentException("Step cannot be zero.");
        }

        if ((range.from < range.to && range.step < 0) || (range.from > range.to && range.step > 0))
        {
            throw new ArgumentException("Invalid range and step combination.");
        }
        for (var i = range.from; i < range.to; i += range.step)
        {
            yield return i;
        }
    }
    
    /// <summary>
    /// Produces an enumerator that yields longs between the provided range.
    /// </summary>
    /// <param name="range">The tuple containing the start and end values of the range.</param>
    /// <returns>An enumerator of longs.</returns>
    public static IEnumerator<long> GetEnumerator(this (long from, long to) range)
    {
        if (range.from > range.to)
        {
            throw new ArgumentException("Start value (from) cannot be greater than end value (to).");
        }
        
        for (var i = range.from; i < range.to; i++)
        {
            yield return i;
        }
    }

    /// <summary>
    /// Produces an enumerator that yields longs between the provided range, advancing by the specified step.
    /// </summary>
    /// <param name="range">The tuple containing the start and end values of the range and the step value for each iteration.</param>
    /// <returns>An enumerator of longs.</returns>
    public static IEnumerator<long> GetEnumerator(this (long from, long to, long step) range)
    {
        if (range.step == 0)
        {
            throw new ArgumentException("Step cannot be zero.");
        }

        if ((range.from < range.to && range.step < 0) || (range.from > range.to && range.step > 0))
        {
            throw new ArgumentException("Invalid range and step combination.");
        }
        
        for (var i = range.from; i < range.to; i += range.step)
        {
            yield return i;
        }
    }
}