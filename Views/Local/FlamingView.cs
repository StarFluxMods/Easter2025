using UnityEngine;
using UnityEngine.VFX;

namespace Easter2025.Views.Local
{
    public class FlamingView : MonoBehaviour
    {
        public VisualEffect Fire;

        private void Awake()
        {
            if (Fire == null) return;
            Fire.initialEventName = "OnPlay";
            Fire.SetFloat("Active", 1);
            Fire.Play();
        }
    }
}