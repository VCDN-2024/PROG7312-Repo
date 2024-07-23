using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysSpaceVC
{
    public class Spaceship
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int CrewCapacity { get; set; }
        public double MaxSpeed { get; set; }
        public string Status { get; set; } 
        public DateTime LaunchDate { get; set; }
        public string MissionType { get; set; } 

        public Spaceship(string name, string model, int crewCapacity, double maxSpeed, string status, DateTime launchDate, string missionType)
        {
            Name = name;
            Model = model;
            CrewCapacity = crewCapacity;
            MaxSpeed = maxSpeed;
            Status = status;
            LaunchDate = launchDate;
            MissionType = missionType;
        }

        public override string ToString()
        {
            return $"{Name} (Model: {Model}, Crew Capacity: {CrewCapacity}, Max Speed: {MaxSpeed}, Status: {Status}, Launch Date: {LaunchDate.ToShortDateString()}, Mission Type: {MissionType})";
        }
    }

}
