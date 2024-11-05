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
                },
                new Island() {
                    Id = 2,
                    Name = "Maldives",
                    Description = "The maldives is a country that is filled with a series of 1,192 different exotic islands.",
                    Country = "Maldives",
                    Base64Image = ""
                },
                new Island() {
                    Id = 3,
                    Name = "Tahiti",
                    Description = "Tahiti is the largest island in French Polunesia. It has a shape of a figure-8 when viewed from above.",
                    Country = "French Polynesia",
                    Base64Image = ""
                },
                new Island() {
                    Id = 4,
                    Name = "Seychelles",
                    Description = "The seychelles is the smallest country in Africa and holds a number of 115 islands in the Indian Ocean.",
                    Country = "Seychelles",
                    Base64Image = ""
                },
                new Island() {
                    Id = 5,
                    Name = "Palawan",
                    Description = "Palawan is an archipelagic province located in the region of Mimaropa.",
                    Country = "Philippines",
                    Base64Image = ""
                },
                new Island() {
                    Id = 6,
                    Name = "Bali",
                    Description = "Bali is a province of Indonesia and the westernmost of the Lesser Sunda Islands.",
                    Country = "Indonesia",
                    Base64Image = ""
                },
                new Island() {
                    Id = 7,
                    Name = "Hawaii",
                    Description = "Hawaii is an island state in the Pacific Ocean, the only US state in the tropics.",
                    Country = "United States",
                    Base64Image = ""
                },
                new Island() {
                    Id = 8,
                    Name = "Saint Kitts and Nevis",
                    Description = "An island country consisting of the two islands of Saint Kitts and Nevis.",
                    Country = "Saint Kitts and Nevis",
                    Base64Image = ""
                },
                new Island() {
                    Id = 9,
                    Name = "Ko Phi Phi",
                    Description = "Phi Phi Islands are an island group in Thailand between the large island of Phuket and Straits of Malacca coast of Thailand.",
                    Country = "Thailand",
                    Base64Image = ""
                },
                new Island() {
                    Id = 10,
                    Name = "Galapagos Islands",
                    Description = "The Galapagos Islands is a volcanic archipelago and also considered one of the world's foremost destinations for wildlife-viewing.",
                    Country = "Ecuador",
                    Base64Image = ""
                },
            };

            

            return islands;
        }
    }
}