// ReSharper disable CheckNamespace
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedType.Global

using System.Diagnostics.CodeAnalysis;

/// <summary>
/// Provides extension methods for the <see cref="ValueTuple"/> type.
/// </summary>
[SuppressMessage("Design", "CA1050:Declare types in namespaces")]
public static class HamedStackValueTupleExtensions
{
    /// <summary>
    /// Provides an enumerator for the provided single-item tuple.
    /// </summary>
    /// <typeparam name="T1">The type of the first item in the tuple.</typeparam>
    /// <param name="tuple">The tuple to enumerate.</param>
    /// <returns>An enumerator for the tuple items.</returns>
    public static IEnumerator<object?> GetEnumerator<T1>(this ValueTuple<T1?> tuple)
    {
        yield return tuple.Item1;
    }

    /// <summary>
    /// Provides an enumerator for the provided two-item tuple.
    /// </summary>
    /// <typeparam name="T1">The type of the first item in the tuple.</typeparam>
    /// <typeparam name="T2">The type of the second item in the tuple.</typeparam>
    /// <param name="tuple">The tuple to enumerate.</param>
    /// <returns>An enumerator for the tuple items.</returns>
    public static IEnumerator<object?> GetEnumerator<T1, T2>(this ValueTuple<T1, T2> tuple)
    {
        yield return tuple.Item1;
        yield return tuple.Item2;
    }

    /// <summary>
    /// Provides an enumerator for the provided seven-item tuple.
    /// </summary>
    /// <typeparam name="T1">The type of the first item in the tuple.</typeparam>
    /// <typeparam name="T2">The type of the second item in the tuple.</typeparam>
    /// <typeparam name="T3">The type of the third item in the tuple.</typeparam>
    /// <param name="tuple">The tuple to enumerate.</param>
    /// <returns>An enumerator for the tuple items.</returns>
    public static IEnumerator<object?> GetEnumerator<T1, T2, T3>(this ValueTuple<T1, T2, T3> tuple)
    {
        yield return tuple.Item1;
        yield return tuple.Item2;
        yield return tuple.Item3;
    }

    /// <summary>
    /// Provides an enumerator for the provided seven-item tuple.
    /// </summary>
    /// <typeparam name="T1">The type of the first item in the tuple.</typeparam>
    /// <typeparam name="T2">The type of the second item in the tuple.</typeparam>
    /// <typeparam name="T3">The type of the third item in the tuple.</typeparam>
    /// <typeparam name="T4">The type of the fourth item in the tuple.</typeparam>
    /// <param name="tuple">The tuple to enumerate.</param>
    /// <returns>An enumerator for the tuple items.</returns>
    public static IEnumerator<object?> GetEnumerator<T1, T2, T3, T4>(this ValueTuple<T1, T2, T3, T4> tuple)
    {
        yield return tuple.Item1;
        yield return tuple.Item2;
        yield return tuple.Item3;
        yield return tuple.Item4;
    }

    /// <summary>
    /// Provides an enumerator for the provided seven-item tuple.
    /// </summary>
    /// <typeparam name="T1">The type of the first item in the tuple.</typeparam>
    /// <typeparam name="T2">The type of the second item in the tuple.</typeparam>
    /// <typeparam name="T3">The type of the third item in the tuple.</typeparam>
    /// <typeparam name="T4">The type of the fourth item in the tuple.</typeparam>
    /// <typeparam name="T5">The type of the fifth item in the tuple.</typeparam>
    /// <param name="tuple">The tuple to enumerate.</param>
    /// <returns>An enumerator for the tuple items.</returns>
    public static IEnumerator<object?> GetEnumerator<T1, T2, T3, T4, T5>(this ValueTuple<T1, T2, T3, T4, T5> tuple)
    {
        yield return tuple.Item1;
        yield return tuple.Item2;
        yield return tuple.Item3;
        yield return tuple.Item4;
        yield return tuple.Item5;
    }

    /// <summary>
    /// Provides an enumerator for the provided seven-item tuple.
    /// </summary>
    /// <typeparam name="T1">The type of the first item in the tuple.</typeparam>
    /// <typeparam name="T2">The type of the second item in the tuple.</typeparam>
    /// <typeparam name="T3">The type of the third item in the tuple.</typeparam>
    /// <typeparam name="T4">The type of the fourth item in the tuple.</typeparam>
    /// <typeparam name="T5">The type of the fifth item in the tuple.</typeparam>
    /// <typeparam name="T6">The type of the sixth item in the tuple.</typeparam>
    /// <param name="tuple">The tuple to enumerate.</param>
    /// <returns>An enumerator for the tuple items.</returns>
    public static IEnumerator<object?> GetEnumerator<T1, T2, T3, T4, T5, T6>(this ValueTuple<T1, T2, T3, T4, T5, T6> tuple)
    {
        yield return tuple.Item1;
        yield return tuple.Item2;
        yield return tuple.Item3;
        yield return tuple.Item4;
        yield return tuple.Item5;
        yield return tuple.Item6;
    }

    /// <summary>
    /// Provides an enumerator for the provided seven-item tuple.
    /// </summary>
    /// <typeparam name="T1">The type of the first item in the tuple.</typeparam>
    /// <typeparam name="T2">The type of the second item in the tuple.</typeparam>
    /// <typeparam name="T3">The type of the third item in the tuple.</typeparam>
    /// <typeparam name="T4">The type of the fourth item in the tuple.</typeparam>
    /// <typeparam name="T5">The type of the fifth item in the tuple.</typeparam>
    /// <typeparam name="T6">The type of the sixth item in the tuple.</typeparam>
    /// <typeparam name="T7">The type of the seventh item in the tuple.</typeparam>
    /// <param name="tuple">The tuple to enumerate.</param>
    /// <returns>An enumerator for the tuple items.</returns>
    public static IEnumerator<object?> GetEnumerator<T1, T2, T3, T4, T5, T6, T7>(this ValueTuple<T1, T2, T3, T4, T5, T6, T7> tuple)
    {
        yield return tuple.Item1;
        yield return tuple.Item2;
        yield return tuple.Item3;
        yield return tuple.Item4;
        yield return tuple.Item5;
        yield return tuple.Item6;
        yield return tuple.Item7;
    }
}