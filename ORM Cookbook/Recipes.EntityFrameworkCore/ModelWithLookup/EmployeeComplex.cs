﻿using Recipes.ModelWithLookup;

namespace Recipes.EntityFrameworkCore.Entities
{
    //Used for linking the entity to the test framework. Not part of the recipe.
    partial class Employee : IEmployeeComplex
    {
        IEmployeeClassification? IEmployeeComplex.EmployeeClassification
        {
            get => EmployeeClassificationKeyNavigation;
            set => EmployeeClassificationKeyNavigation = (EmployeeClassification?)value;
        }
    }
}
