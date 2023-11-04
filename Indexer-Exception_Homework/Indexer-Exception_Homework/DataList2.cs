using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Exception_Homework
{
    public static class DataList2
    {
        public static int IndexOf<T>(this T[] array, T item)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (object.Equals(array[i], item))
                {
                    return i;
                }
            }

            return -1;
        }

        public static T[] DeleteId<T>(this T[] array, T item)
        {
            int deleteItemIndex = -1;

            for (int i = 0; i <= array.Length; i++)
            {
                if (object.Equals(array[i], item))
                {
                    deleteItemIndex = i;
                    break;
                }
            }

            if (deleteItemIndex != -1)
            {
                T[] newArray = new T[array.Length - 1];

                int newIndex = 0;

                for (int i = 0;i < array.Length; i++)
                {
                    if (i != deleteItemIndex)
                    {
                        newArray[newIndex] = array[i];
                        newIndex++;
                    }
                }

                return newArray;
            }
            else { return null; }
        }
    }
}
