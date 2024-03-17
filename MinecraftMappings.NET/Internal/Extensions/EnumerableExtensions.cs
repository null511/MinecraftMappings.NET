using System;
using System.Collections.Generic;
using System.Linq;

namespace MinecraftMappings.Internal.Extensions
{
    internal static class EnumerableExtensions
    {
        public static IEnumerable<T> WhereNotNull<T>(this IEnumerable<T?> collection)
        {
            if (collection == null) throw new ArgumentNullException(nameof(collection));

            return collection.Where(item => item != null).OfType<T>();
        }

        public static IEnumerable<T> WhereNotNull<T>(this IEnumerable<T?> collection, Func<T, bool> filter)
        {
            if (collection == null) throw new ArgumentNullException(nameof(collection));
            if (filter == null) throw new ArgumentNullException(nameof(filter));

            return collection.Where(item => item != null && filter(item)).OfType<T>();
        }
    }
}
