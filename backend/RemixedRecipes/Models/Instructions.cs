﻿using System;
using System.ComponentModel.DataAnnotations;

namespace RemixedRecipes.Models
{
    public class Instructions
    {
        [Key]
        public int Id { get; set; }
        public string InstructionsText { get; set; }

        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }

        public Instructions()
        {
        }
    }
}
