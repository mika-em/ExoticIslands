using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExoticIslands_api.Models;

namespace ExoticIslands_api.Data
{
    public class SampleData
    {
        public static List<Island> GetIslands() 
        {
            List<Island> islands = new List<Island>() {
                new Island() {
                    Id = 1,
                    Name = "Bora Bora",
                    Description = "Famous for its seaside luxury resorts, turquoise lagoons, and coral reefs.",
                    Country = "French Polynesia",
                    Base64Image = ""
                }
            };

            return islands;
        }
    }
}