using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Snake
{
    public sealed class SnakeViewModel : ISnakeViewModel
    {
        public Text ScoreText;
        public int score = 0;

        public List<GameObject> tailObjects = new List<GameObject>();
        public GameObject tailPrefab;

        private readonly SnakeModel _snakeModel;
        private readonly SnakeView _snakeView;

        public SnakeViewModel(SnakeModel snakeModel)
        {
            _snakeModel = snakeModel;
        }

        public void GameScore()
        {
            ScoreText.text = score.ToString();
        }

        public void SnakeMovement()
        {
            _snakeView.transform.Translate(_snakeModel.Speed * Time.deltaTime * Vector3.forward);

            if (Input.GetKey(KeyCode.D))
            {
                _snakeView.transform.Rotate(_snakeModel.SpeedRotate * Time.deltaTime * Vector3.up);
            }

            if (Input.GetKey(KeyCode.A))
            {
                _snakeView.transform.Rotate((-1) * _snakeModel.SpeedRotate * Time.deltaTime * Vector3.up);
            }
        }

        public void AddTail()
        {
            score++;
            Vector3 newTailPosition = tailObjects[tailObjects.Count - 1].transform.position;
            newTailPosition.z -= _snakeModel.ZOffset;
            tailObjects.Add(GameObject.Instantiate(tailPrefab, newTailPosition, Quaternion.identity));
        }

    }
}


