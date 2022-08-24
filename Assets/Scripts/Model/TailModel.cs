using UnityEngine;

namespace Snake
{
    public class TailModel : ITailModel
    {
        public GameObject TailTargetObject { get; set; }
        public Vector3 TailTarget { get; set; }
        public float Speed { get; set; }

        public TailModel(GameObject tailTargetObject, Vector3 tailTargetPosition, float speedTail)
        {
            TailTargetObject = tailTargetObject;
            TailTarget = tailTargetPosition;
            Speed = speedTail;
        }
    }
}

