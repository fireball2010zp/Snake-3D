using UnityEngine;

namespace Snake
{
    public class FoodSpawnerViewModel : IFoodSpawnerViewModel
    {
        public float XSizeField { get; }
        public float ZSizeField { get; }

        public GameObject foodPrefab;

        public GameObject currentFood;

        public Vector3 currentFoodPosition;

        public FoodSpawnerViewModel(float xSizeField, float zSizeField)
        {
            XSizeField = xSizeField;
            ZSizeField = zSizeField;
        }

        public void AddNewFood()
        {
            currentFoodPosition = new Vector3(Random.Range(XSizeField * (-1), XSizeField), 0.5f, Random.Range(ZSizeField * (-1), ZSizeField));
            currentFood = GameObject.Instantiate(foodPrefab, currentFoodPosition, Quaternion.identity);
        }
    }
}

