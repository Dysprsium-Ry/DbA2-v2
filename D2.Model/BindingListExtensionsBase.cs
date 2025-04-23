using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace BienvenidoOnlineTutorServices.D2.Objects
{
    public static class BindingListExtensionsBase
    {
        public static void AddRange<T>(this BindingList<T> bindingList, IEnumerable<T> items)
        {
            if (bindingList == null) return;
            if (items == null) return;

            foreach (var item in items)
            {
                bindingList.Add(item);
            }
        }

        public static void ResetWith<T>(this BindingList<T> list, IEnumerable<T> items)
        {
            list.Clear();
            list.AddRange(items);
        }

        public static decimal Sum<T>(this BindingList<T> list, Func<T, decimal> selector)
        {
            return list.Select(selector).Sum();
        }

        public static void UpdateItem<T>(this BindingList<T> list, int index, T newItem)
        {
            if (index >= 0 && index < list.Count)
            {
                list[index] = newItem;
            }
        }
    }
}