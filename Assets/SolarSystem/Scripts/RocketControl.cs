using UnityEngine;

namespace SolarSystem.Scripts
{
    public class RocketControl : MonoBehaviour
    {
        public float _turnForce;
        public GameObject _engineLight;
        public float _rocketForce;

        private bool _engineOn;
        private Rigidbody _rigidbody;

        private void Start()
        {
            // Grab a reference to the rigid body
            _rigidbody = GetComponent<Rigidbody>();
            
            // Lock the cursor to make mouse control easier
            // Cursor.lockState = CursorLockMode.Locked;
        }

        void Update()
        {
            // Get the mouse controls
            var yaw = Input.GetAxis("Mouse X");
            var pitch = -Input.GetAxis("Mouse Y");
            var roll = -Input.GetAxis("Horizontal");

            // Apply turning forces to the rocket
            _rigidbody.AddRelativeTorque(pitch * _turnForce * Time.deltaTime,
                yaw * _turnForce * Time.deltaTime,
                roll * _turnForce * Time.deltaTime);

            // Turn on the engine when the W key is pressed
            if (Input.GetKeyDown(KeyCode.W))
            {
                _engineOn = true;
                
                // Show the engine light
                _engineLight.SetActive(true);
            }

            // Turn off the engine when the W key is released
            if (Input.GetKeyUp(KeyCode.W))
            {
                _engineOn = false;
                
                // Hide the engine light
                _engineLight.SetActive(false);
            }

            // If the engine is on
            if (_engineOn)
            {
                // Apply a force to the rocket
                _rigidbody.AddForce(_rocketForce * transform.forward);
            }
        }
    }
}
