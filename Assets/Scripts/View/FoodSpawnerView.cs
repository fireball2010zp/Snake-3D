using UnityEngine;

namespace Snake
{
    public class FoodSpawnerView : MonoBehaviour
    { 

        private FoodSpawnerViewModel _foodSpawnerViewModel;

        public void Initialize(FoodSpawnerViewModel foodSpawnerViewModel)
        {
            _foodSpawnerViewModel = foodSpawnerViewModel; 
        }

        void Update()
        {
            if (!_foodSpawnerViewModel.currentFood)
            {
                _foodSpawnerViewModel.AddNewFood();
            }
            else
            {
                return;
            }
        }
    }
}


