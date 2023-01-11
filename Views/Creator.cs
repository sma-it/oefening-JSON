﻿using SaveToFile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveToFile.Views
{
    internal class Creator
    {

        public Book CreateBook()
        {
            Console.Write("Name: ");
            var name = Console.ReadLine();
            Console.Write("Author: ");
            var author = Console.ReadLine();

            return new Book(name, author);
        }

        public Game CreateGame()
        {
            Console.Write("Name: ");
            var name = Console.ReadLine();
            
            Console.Write("ReleaseYear: ");
            var yearString = Console.ReadLine();
            int year;
            try
            {
                year = int.Parse(yearString);
            } catch (Exception)
            {
                year = 0;
            }

            Console.Write("Rating: ");
            var ratingString = Console.ReadLine();
            int rating;
            try
            {
                rating = int.Parse(ratingString);
            }
            catch (Exception)
            {
                rating = 0;
            }

            return new Game(name, year, rating);
        }
    }
}
