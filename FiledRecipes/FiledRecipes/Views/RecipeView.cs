using FiledRecipes.Domain;
using FiledRecipes.App.Mvp;
using FiledRecipes.Properties;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FiledRecipes.Views
{
    /// <summary>
    /// 
    /// </summary>
    public class RecipeView : ViewBase, IRecipeView
    {
        public void Show(IRecipe recipe)
        {

            
            Header = recipe.Name;
            ShowHeaderPanel();
            

            Console.WriteLine("\nIngredienser");

            foreach (var ingredient in recipe.Ingredients)
            {
                Console.WriteLine(ingredient);
            }

            Console.WriteLine("\nInstruktioner");

            foreach (var instruction in recipe.Instructions)
            {
                Console.WriteLine(instruction);
            }
        }

        public void Show(IEnumerable<IRecipe> recipes)
        {
            foreach (var recipe in recipes)
            {
                Show(recipe);
                ContinueOnKeyPressed();
            }
        }
    }
}
