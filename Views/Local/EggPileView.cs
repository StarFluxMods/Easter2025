using UnityEngine;

namespace Easter2025.Views.Local
{
    public class EggPileView : MonoBehaviour
    {
        public GameObject Egg1;
        public GameObject Egg2;
        public GameObject Egg3;
        private void Awake()
        {
            foreach (Transform subEgg in Egg1.transform)
            {
                subEgg.gameObject.SetActive(false);
            }
            foreach (Transform subEgg in Egg2.transform)
            {
                subEgg.gameObject.SetActive(false);
            }
            foreach (Transform subEgg in Egg3.transform)
            {
                subEgg.gameObject.SetActive(false);
            }
            Egg1.transform.GetChild(Random.Range(0, Egg1.transform.childCount)).gameObject.SetActive(true);
            Egg2.transform.GetChild(Random.Range(0, Egg2.transform.childCount)).gameObject.SetActive(true);
            Egg3.transform.GetChild(Random.Range(0, Egg3.transform.childCount)).gameObject.SetActive(true);
        }
    }
}