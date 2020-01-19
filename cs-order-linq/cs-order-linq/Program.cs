﻿using System;
using System.IO;

namespace cs_order_linq
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Windows";
            ShowLargeFileWithoutLinq(path);
        }

        private static void ShowLargeFileWithoutLinq(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            FileInfo[] files = directory.GetFiles();

            foreach (FileInfo file in files)
            {
                Console.WriteLine($"{file.Name} : {file.Length}");
            }
        }
    }
}
