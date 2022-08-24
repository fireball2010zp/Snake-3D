using UnityEngine;

namespace Snake
{
    public sealed class FoodViewModel : IFoodViewModel
    {
        private readonly FoodView _foodView; 

        public void FoodDestroy()
        {
            Object.Destroy(_foodView.gameObject);
        }
    }
}

