using System;

interface IMealPlan
{
    void ShowMeal();
}

class VegetarianMeal : IMealPlan
{
    public void ShowMeal() 
    { 
        Console.WriteLine("Vegetarian meal includes veggies, fruits, and grains."); 
    }
}

class VeganMeal : IMealPlan
{
    public void ShowMeal() 
    { 
        Console.WriteLine("Vegan meal includes plant-based foods only."); 
    }
}

class KetoMeal : IMealPlan
{
    public void ShowMeal() 
    { 
        Console.WriteLine("Keto meal includes high fat and low carbs."); 
    }
}

class Meal<T> where T : IMealPlan, new()
{
    private T meal = new T();

    public void DisplayMealPlan() 
    { 
        meal.ShowMeal(); 
    }
}

class MealHelper
{
    public static void GenerateMealPlan<T>(T meal) where T : IMealPlan
    {
        Console.WriteLine("Generating meal plan...");
        meal.ShowMeal();
    }
}

class Program
{
    static void Main()
    {
        Meal<VeganMeal> veganMeal = new Meal<VeganMeal>();
        Meal<KetoMeal> ketoMeal = new Meal<KetoMeal>();

        veganMeal.DisplayMealPlan();
        ketoMeal.DisplayMealPlan();

        Console.WriteLine("\nUsing Generic Method:");
        MealHelper.GenerateMealPlan(new VegetarianMeal());
    }
}

