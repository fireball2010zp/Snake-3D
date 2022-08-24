using UnityEngine;

namespace Snake 
{
    internal sealed class BordersView : MonoBehaviour
    {
        private readonly BordersViewModel _bordersViewModel;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("SnakeMain"))
            {
                _bordersViewModel.BordersTrigger();
            }
        }
    }
}