﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" hello all welcome to HashTable Problems");
            string paragraph = "To be or not to be";
            CountWords(paragraph);
            Console.ReadLine();
        }
        /// <summary>
        /// Counts the words.
        /// </summary>
        /// <param name="paragraph">The paragraph.</param>
        public static void CountWords(string paragraph)
        {
            MyMapNode<string, int> myMapNode = new MyMapNode<string, int>(6);
            string[] words = paragraph.Split(' ');
            foreach (string word in words)
            {
                if (myMapNode.Exists(word))
                    myMapNode.Add(word.ToLower(), myMapNode.Get(word) + 1);
                else
                    myMapNode.Add(word.ToLower(), 1);
            }
            Console.WriteLine("Display after Add operation");
            myMapNode.Display();
            Console.ReadLine();
        }
    }
}
