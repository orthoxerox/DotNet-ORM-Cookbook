﻿using Recipes.ModelWithLookup;

namespace Recipes.EntityFrameworkCore.Entities
{
    //Used for linking the entity to the test framework. Not part of the recipe.
    partial class EmployeeClassification : IEmployeeClassification
    {
        bool IEmployeeClassification.IsEmployee => IsEmployee ?? true;
    }
}
