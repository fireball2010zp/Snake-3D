using UnityEngine;
using UnityEngine.SceneManagement;

namespace Snake
{
    public sealed class TailViewModel : ITailViewModel
    {
        public SnakeModel headSnake;
        public SnakeViewModel _snakeViewModel;

        private readonly TailModel _tailModel;
        private readonly TailView _tailView;

        public int tailIndex;

        public void TailMovement()
        {
            _tailModel.TailTarget = _tailModel.TailTargetObject.transform.position;
            _tailView.transform.LookAt(_tailModel.TailTarget);
            _tailView.transform.position = Vector3.Lerp(_tailView.transform.position, _tailModel.TailTarget, Time.deltaTime * _tailModel.Speed);
        }

        public void TailSpeed()
        {
            _tailModel.Speed = headSnake.Speed * 1.5f;
        }

        public void TailTarget()
        {
            _tailModel.TailTargetObject = _snakeViewModel.tailObjects[_snakeViewModel.tailObjects.Count - 2];
            tailIndex = _snakeViewModel.tailObjects.IndexOf(_tailView.gameObject);
        }

        public void TailTrigger()
        {
            SceneManager.LoadScene(0);
        }
    }
}