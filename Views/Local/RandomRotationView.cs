using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Easter2025.Views.Local
{
    public class RandomRotationView : MonoBehaviour
    {
        public float min = -180f;
        public float max = 180f;
        public GameObject Container;
        private void Awake()
        {
            Container.transform.rotation = Quaternion.Euler(0, Random.Range(min, max), 0);
        }
    }
}