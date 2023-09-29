using System;
using System.Collections.Generic;
using System.Linq;

namespace lab03
{
    public class CustomList<T> : List<T>
    {
        public static CustomList<T> operator !(CustomList<T> list)
        {
            CustomList<T> reversedList = new CustomList<T>();

            for (int i = list.Count - 1; i >= 0; i--)
            {
                reversedList.Add(list[i]);
            }

            return reversedList;
        }

        public static CustomList<T> operator +(CustomList<T> leftList, CustomList<T> rightList)
        {
            CustomList<T> result = new CustomList<T>();

            foreach (var item in leftList)
            {
                result.Add(item);
            }

            foreach (var item in rightList)
            {
                result.Add(item);
            }

            return result;
        }

        public static bool operator ==(CustomList<T> leftList, CustomList<T> rightList)
        {
            if (ReferenceEquals(leftList, null) && ReferenceEquals(rightList, null))
            {
                return true;
            }

            if (ReferenceEquals(leftList, null) || ReferenceEquals(rightList, null))
            {
                return false;
            }

            return leftList.SequenceEqual(rightList);
        }

        public static bool operator !=(CustomList<T> leftList, CustomList<T> rightList)
        {
            return !(leftList == rightList);
        }

        public static CustomList<T> operator <(CustomList<T> leftList, CustomList<T> rightList)
        {
            if (leftList == null)
            {
                throw new ArgumentNullException("leftList");
            }

            if (rightList == null)
            {
                throw new ArgumentNullException("rightList");
            }

            if (leftList.Count != rightList.Count)
            {
                throw new ArgumentException("Списки должны быть одинаковой длины!");
            }
            
            CustomList<T> result = new CustomList<T>();
            
            if (typeof(T) == typeof(int) || typeof(T) == typeof(double) || typeof(T) == typeof(float))
            {
                for (int i = 0; i < leftList.Count(); i++)
                {
                    T sum = (dynamic)leftList[i] + (dynamic)rightList[i];
                    result.Add(sum);
                }
            }
            else
            {
                throw new ArgumentException("Тип T не поддерживает операцию сложения!");
            }

            return result;
        }
        
        public static CustomList<T> operator >(CustomList<T> leftList, CustomList<T> rightList)
        {
            if (leftList == null)
            {
                throw new ArgumentNullException("leftList");
            }

            if (rightList == null)
            {
                throw new ArgumentNullException("rightList");
            }

            if (leftList.Count != rightList.Count)
            {
                throw new ArgumentException("Списки должны быть одинаковой длины!");
            }
            
            CustomList<T> result = new CustomList<T>();
            
            if (typeof(T) == typeof(int) || typeof(T) == typeof(double) || typeof(T) == typeof(float))
            {
                for (int i = 0; i < leftList.Count(); i++)
                {
                    T sum = (dynamic)leftList[i] - (dynamic)rightList[i];
                    result.Add(sum);
                }
            }
            else
            {
                throw new ArgumentException("Тип T не поддерживает операцию вычитания!");
            }

            return result;
        }

        public T SumElements(CustomList<T> list)
        {
            T sum = default(T);
            if (typeof(T) == typeof(int) || typeof(T) == typeof(double) || typeof(T) == typeof(float))
            {
                
                for (int i = 0; i < list.Count; i++)
                {
                    sum += (dynamic)list[i];
                }
            }
            else
            {
                throw new ArgumentException("Тип T не поддерживает операцию сложения!");
            }

            return sum;
        }
    }
}