using UnityEngine;

namespace Snake
{
    internal sealed class SnakeView : MonoBehaviour 
    {
        public SnakeViewModel _snakeViewModel;

        public void Initialize(SnakeViewModel snakeViewModel)
        {
            _snakeViewModel = snakeViewModel;
        }

        void Start()
        {
            _snakeViewModel.tailObjects.Add(gameObject);
        }

        void Update()
        {
            _snakeViewModel.GameScore();
            _snakeViewModel.SnakeMovement();
        }
    }
}