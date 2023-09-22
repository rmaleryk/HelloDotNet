using System;
using System.Collections.Generic;

namespace HelloDotNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var message = "Hello .NET!";

            // Conditions

            if (message.Length > 5)
            {
                Console.WriteLine($"Long: {message}");
            }
            else
            {
                Console.WriteLine($"Short: {message}");
            }

            // Switch

            switch (message.Length)
            {
                case 5: Console.WriteLine(message); return;
            }

            // Ternary

            var displayedMessage = message.Length > 5
                ? $"Long: {message}"
                : $"Short: {message}";

            // The same

            if (message.Length > 5)
            {
                displayedMessage = $"long: {message}";
            }
            else
            {
                displayedMessage = $"short: {message}";
            }

            Console.WriteLine(displayedMessage);

            // Exceptions

            var first = 1;
            var second = 0;

            try
            {
                var d = first / second;
                Console.WriteLine($"Result: {d}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine($"The value cannot be 0");
            }

            // Arrays and other data structures

            var array = new[] { 1, 2, 3, };

            foreach (var item in array)
            {
                Console.WriteLine($"Item: {item}");
            }

            var list = new List<int> { 1, 2, 3 } as IEnumerable<int>;

            foreach (var item in list)
            {
                Console.WriteLine($"Item: {item}");
            }

            var linkedList = new LinkedList<int>();
            var stack = new Stack<int>();
            var queue = new Queue<int>();

            var dictionary = new Dictionary<int, string>(); // Key - value storage
            var hashSet = new HashSet<int>(); // Keys storage

            var hasValue = dictionary.TryGetValue(1, out var value);
            
            if (hasValue)
            {
                Console.WriteLine($"Has value: {value}");
            }
            else
            {
                Console.WriteLine($"Has value: {value}");
            }
        }
    }
}