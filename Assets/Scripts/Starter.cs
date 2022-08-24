using UnityEngine;

namespace Snake
{
    internal sealed class Starter : MonoBehaviour
    {
        void Start()
        {
            var foodSpawnerViewModel = new FoodSpawnerViewModel(12f, 8f);
            FindObjectOfType<FoodSpawnerView>().Initialize(foodSpawnerViewModel);

            var snakeModel = new SnakeModel(3, 120, 2);
            var snakeViewModel = new SnakeViewModel(snakeModel);
            FindObjectOfType<SnakeView>().Initialize(snakeViewModel);
        }
    }
}


