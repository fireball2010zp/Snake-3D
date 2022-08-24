
using UnityEngine;

namespace Snake
{
    public interface ITailModel
    {
        public Vector3 TailTarget { get; set; }
        public GameObject TailTargetObject { get; set; } 
        public float Speed { get; set; }
    }
}

