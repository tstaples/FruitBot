﻿using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using RSAdventurerLogScraper;
using static RunescapeAPITest.RSDropLog;
using System.Globalization;

namespace FruitPantry
{
    class Program
    {

        static void Main(string[] args)
        {
            //FruitPantry thePantry = new("FruitBot", "1iCJHsiC4nEjjFz1Gmw4aTldnMFR5ZAlGSuJfHbP262s", "Drop Log", "credentials.json");

            //thePantry.AddEntry(new("i", "like", "big", "phat", "doggies", "juicy", "plump", "when", "theyare"));



            //List<DropLogEntry> scraped = DropLogEntry.CreateListFullAuto();


            //thePantry.Add(scraped);

            //{Element (id = ab88da5a-8fee-41c7-9482-354fd167084d)}
            Console.WriteLine();
            //var source = driver.PageSource;

            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
   
               string dropname = ti.ToTitleCase("I found an off-hand drygore mace"
                    .Replace("I found some ", "")
                    .Replace("I found an ", "")
                    .Replace("I found a ", "")
                    .Replace("I found ", "")
                    .Replace("Found an ", "")
                    .Replace("pair of ", "")
                    .Replace(".", ""));
            Console.WriteLine(dropname);
      

            Console.WriteLine();
        }
    }
}