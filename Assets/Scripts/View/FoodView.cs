using UnityEngine;

namespace Snake
{
    internal sealed class FoodView : MonoBehaviour 
    {
        private readonly FoodViewModel _foodViewModel; 

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("SnakeMain"))
            {
                other.GetComponent<SnakeViewModel>().AddTail();
                _foodViewModel.FoodDestroy();
            }
        }
    }
}