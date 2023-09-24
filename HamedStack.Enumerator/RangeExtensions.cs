// ReSharper disable CheckNamespace
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedType.Global

using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

/// <summary>
/// Provides extension methods for the <see cref="Range"/> type.
/// </summary>
[SuppressMessage("Design", "CA1050:Declare types in namespaces")]
public static class HamedStackRangeExtensions
{
    /// <summary>
    /// Produces an enumerator that yields integers between the start and end values of the provided range.
    /// The direction of enumeration depends on whether the start is from the end or not.
    /// </summary>
    /// <param name="range">The range for which to produce an enumerator.</param>
    /// <returns>An enumerator of integers.</returns>
    public static IEnumerator<int> GetEnumerator(this Range range)
    {
        if (range.Start.IsFromEnd)
        {
            var startValue = range.Start.Value;
            var endValue = range.End.Value;

            if (startValue < 0 || endValue < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(range), "Start and end values must be non-negative.");
            }

            for (var i = startValue; i >= endValue; i--)
            {
                yield return i;
            }
        }
        else
        {
            var startValue = range.Start.Value;
            var endValue = range.End.Value;

            if (startValue < 0 || endValue < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(range), "Start and end values must be non-negative.");
            }

            for (var i = startValue; i <= endValue; i++)
            {
                yield return i;
            }
        }
    }

    /// <summary>
    /// Produces an enumerable sequence of integers based on the provided range and collection length.
    /// It calculates the actual start and end indices using the collection length.
    /// </summary>
    /// <param name="range">The range for which to produce an enumerable sequence.</param>
    /// <param name="collectionLength">The length of the collection from which the range is derived.</param>
    /// <returns>An enumerable sequence of integers.</returns>
    public static IEnumerable<int> AsEnumerable(this Range range, int collectionLength)
    {
        if (collectionLength < 0)
        {
            throw new ArgumentException("Collection length must be non-negative.", nameof(collectionLength));
        }

        var start = range.Start.GetOffset(collectionLength);
        var end = range.End.GetOffset(collectionLength);

        if (start < 0 || start >= collectionLength)
        {
            throw new ArgumentOutOfRangeException(nameof(range.Start), "Start index is out of range.");
        }

        if (end < 0 || end >= collectionLength)
        {
            throw new ArgumentOutOfRangeException(nameof(range.End), "End index is out of range.");
        }

        var step = start <= end ? 1 : -1;

        if (range.End.IsFromEnd || start < end)
        {
            end -= step;
        }

        for (var i = start; step > 0 ? i <= end : i >= end; i += step)
        {
            yield return i;
        }
    }
}