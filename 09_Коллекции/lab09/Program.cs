using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace lab09
{
    internal class Program
    {
        public static void FirstTask()
        {
            Console.WriteLine("\t\tПервое задание");

            List<InternetResource> resourceList = new List<InternetResource>();

            InternetResource resource1 = new InternetResource("Resource 1", "example.com", "Description 1", "Metadata 1");
            InternetResource resource2 = new InternetResource("Resource 2", "sample.com", "Description 2", "Metadata 2");
            InternetResource resource3 = new InternetResource("Resource 3", "test.com", "Description 3", "Metadata 3");
            InternetResource resource4 = new InternetResource("Resource 4", "demo.com", "Description 4", "Metadata 4");

            resource1.AddPage("Page 1");
            resource1.AddPage("Page 2");
            resource2.AddPage("Page A");
            resource2.AddPage("Page B");
            resource3.AddPage("Page X");
            resource3.AddPage("Page Y");
            resource4.AddPage("Page Z");
            resource4.AddPage("Page W");

            resourceList.Add(resource1);
            resourceList.Add(resource2);
            resourceList.Add(resource3);
            resourceList.Add(resource4);

            foreach (InternetResource resource in resourceList)
            {
                Console.WriteLine($"Имя ресурса: {resource.Resource.Name}");
                Console.WriteLine("Страницы ресурса:");
                foreach (string page in resource)
                {
                    Console.WriteLine(page);
                }
            }
        }

        public static void SecondTask()
        {
            Console.WriteLine("\t\tВторое задание");

            ConcurrentQueue<int> collection = new ConcurrentQueue<int>();
            for (int i = 1; i <= 10; i++)
            {
                collection.Enqueue(i);
            }

            int n = 3;
            for (int i = 0; i < n; i++)
            {
                int removedItem;
                if (collection.TryDequeue(out removedItem))
                {
                    Console.WriteLine($"Удалён: {removedItem}");
                }
            }

            for (int i = 11; i <= 15; i++)
            {
                collection.Enqueue(i);
            }

            List<int> secondCollection = new List<int>(collection);

            Console.WriteLine("Вторая коллекция:");
            foreach (int item in secondCollection)
            {
                Console.WriteLine(item);
            }

            int targetValue = 8;
            if (secondCollection.Contains(targetValue))
            {
                Console.WriteLine($"Значение {targetValue} найдено в другой коллекции.");
            }
            else
            {
                Console.WriteLine($"Значение {targetValue} не найдено в другой коллекции.");
            }
        }

        public static void ThirdTask()
        {
            Console.WriteLine("\t\tТретье задание");

            ObservableCollection<InternetResource> resourceCollection = new ObservableCollection<InternetResource>();

            resourceCollection.CollectionChanged += ResourceCollectionChanged;

            InternetResource resource1 = new InternetResource("Resource 1", "example.com", "Description 1", "Metadata 1");
            InternetResource resource2 = new InternetResource("Resource 2", "sample.com", "Description 2", "Metadata 2");

            resourceCollection.Add(resource1);
            resourceCollection.Add(resource2);

            Console.WriteLine("\nКоллекция:");
            PrintResourceCollection(resourceCollection);
            Console.WriteLine();

            InternetResource resource3 = new InternetResource("Resource 3", "test.com", "Description 3", "Metadata 3");
            resourceCollection.Add(resource3);

            Console.WriteLine("\nКоллекция после добавления Resource 3:");
            PrintResourceCollection(resourceCollection);
            Console.WriteLine();

            resourceCollection.RemoveAt(1);

            Console.WriteLine("\nКоллекция после удаления Resource 2:");
            PrintResourceCollection(resourceCollection);
        }

        private static void ResourceCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                Console.WriteLine("Элементы добавлены в коллекцию.");
            }
            else if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("Элементы удалены из коллекции.");
            }
        }

        private static void PrintResourceCollection(ObservableCollection<InternetResource> collection)
        {
            foreach (InternetResource resource in collection)
            {
                Console.WriteLine($"Имя ресурса: {resource.Resource.Name}");
            }
        }

        static void Main(string[] args)
        {
            FirstTask();
            SecondTask();
            ThirdTask();
        }
    }
}