using UnityEngine;
using Random = UnityEngine.Random;

namespace Easter2025.Views.Local
{
    public class RandomPlacementView : MonoBehaviour
    {
        public Vector3 min = new(0, 0, 0);
        public Vector3 max = new(0, 0, 0);
        public GameObject Container;
        private void Awake()
        {
            Container.transform.position = new Vector3(Random.Range(min.x, max.x), Random.Range(min.y, max.y), Random.Range(min.z, max.z)) + Container.transform.position;
        }
    }
}