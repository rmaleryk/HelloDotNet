using System;
using System.Collections.Generic;
using System.Linq;
using HelloDotNet.Enums;
using HelloDotNet.Models;

namespace HelloDotNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var message = "Hello .NET!";
            var log = (string message) => { Console.WriteLine(message); };

            // Conditions

            if (message.Length > 5)
            {
                log($"Long: {message}");
            }
            else
            {
                log($"Short: {message}");
            }

            // Switch

            switch (message.Length)
            {
                case 5: log(message); return;
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
                log($"Result: {d}");
            }
            catch (DivideByZeroException)
            {
                log($"The value cannot be 0");
            }

            // Arrays and other data structures

            var array = new[] { 1, 2, 3, };

            foreach (var item in array)
            {
                log($"Item: {item}");
            }

            var list = new List<int> { 1, 2, 3 };

            foreach (var item in list)
            {
                log($"Item: {item}");
            }

            var isAllMoreThanTwo = list.All((item) => item > 2);

            var linkedList = new LinkedList<int>();
            var stack = new Stack<int>();
            var queue = new Queue<int>();

            var dictionary = new Dictionary<int, string>(); // Key - value storage
            var hashSet = new HashSet<int>(); // Keys storage

            var hasValue = dictionary.TryGetValue(1, out var value);

            if (hasValue)
            {
                log($"Has value: {value}");
            }
            else
            {
                log($"Has value: {value}");
            }

            // Enums

            var devices = GetDeviceIds(DeviceType.Vacuum);

            // Methods

            var hasHumidifiers = TryGetDeviceIds(DeviceType.Humidifier, out var humidifierIds);

            if (hasHumidifiers)
            {
                log($"Humidifiers: {string.Join(", ", humidifierIds)}");
            }
            else
            {
                log("No humidifiers found");
            }

            var initialDeviceType = DeviceType.Vacuum;
            SetDeviceType(ref initialDeviceType);

            log($"{initialDeviceType}");

            // Classes

            var device = new Device()
            {
                Id = 1,
                Name = "Vacuum cleaner",
                Type = DeviceType.Vacuum
            };
        }

        public static int[] GetDeviceIds(DeviceType type)
        {
            // Some logic
            return new[] { 1 };
        }

        public static bool TryGetDeviceIds(DeviceType type, out int[] deviceIds)
        {
            // Some logic
            deviceIds = new[] { 1 };

            return true;
        }

        public static void SetDeviceType(ref DeviceType type)
        {
            type = DeviceType.Socket;
        }

        public static void SetDeviceType(ref DeviceType type, int deviceId)
        {
            type = DeviceType.Socket;
        }
    }
}