using UnityEngine;

namespace SolarSystem.Scripts
{
    public class Rotate : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private Vector3 _axis;

        void Update()
        {
            transform.Rotate(_axis, _speed * Time.deltaTime);
        }
    }
}
