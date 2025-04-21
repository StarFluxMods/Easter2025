using System.Collections.Generic;
using KitchenLib.Utils;
using UnityEngine;

namespace Easter2025.Views.Local
{
    public class EggPileView : MonoBehaviour
    {
        public List<GameObject> EggContainers = new List<GameObject>();
        private void Awake()
        {
            foreach (GameObject eggContainer in EggContainers)
            {
                foreach (Transform Egg in eggContainer.transform)
                {
                    Egg.gameObject.SetActive(false);
                }
            }

            foreach (GameObject eggContainer in EggContainers)
            {
                eggContainer.transform.GetChild(Random.Range(0, eggContainer.transform.childCount)).gameObject.SetActive(true);
            }
        }
    }
}