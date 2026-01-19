using System;
using System.Collections.Generic;
using System.Text;

namespace Animals_vet
{
    public class Dog : animalsI
    {
        public Dog(string name, DateTime birthday, string breed, string medicalHistory, double weight, string color, string favToy)
        {
            Name = name;
            Birthday = birthday;
            Breed = breed;
            Weight = weight;
            MedicalHistory = medicalHistory;
            Color = color;
            FavToy = favToy;
            Status = Status.NotAdopted;
        }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Breed { get; set; }
        public double Weight { get; set; }
        public string MedicalHistory { get; set; }
        public string Color { get; set; }
        public string FavToy { get; set; }
        public string Image { get; set; }
        public Status Status { get; set; }
    }
}
