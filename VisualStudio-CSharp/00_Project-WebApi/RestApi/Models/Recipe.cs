using System;

namespace RestApi.Models
{
    public class Recipe
    {
        public Recipe()
        {
            Id = 0;
            Name = "";
        }

        public int Id { get; set; }
        public string Name { get; set; }
        // Add other properties as needed
    }
}


