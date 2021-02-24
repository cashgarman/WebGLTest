using UnityEngine;

namespace SolarSystem.Scripts
{
    public class FaceCamera : MonoBehaviour
    {
        void Update()
        {
            transform.forward = Camera.main.transform.forward;
        }
    }
}
