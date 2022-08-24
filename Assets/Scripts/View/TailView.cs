using UnityEngine;

namespace Snake
{
    public class TailView : MonoBehaviour
    {
        private readonly TailViewModel _tailViewModel;

        void Start()
        {
            _tailViewModel._snakeViewModel = GameObject.FindGameObjectWithTag("SnakeMain").GetComponent<SnakeViewModel>();
            _tailViewModel.TailSpeed();
            _tailViewModel.TailTarget();
        }

        void Update()
        {
            _tailViewModel.TailMovement(); 
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("SnakeMain"))
            {
                if (_tailViewModel.tailIndex > 2)
                {
                    _tailViewModel.TailTrigger();
                }
            }
        }
    }
}