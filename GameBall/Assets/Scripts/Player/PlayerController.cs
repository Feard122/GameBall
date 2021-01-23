using UnityEngine;

namespace GameBall
{
    public class PlayerController : MonoBehaviour
    {

        #region Field

        [SerializeField] private float _speed = 3.0f;
        private Rigidbody _rigidbody;
        #endregion

        #region UnityMethod

        void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        void Update()
        {
            Move();
        }
        #endregion


        #region Method

        protected void Move()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

            _rigidbody.AddForce(movement * _speed);
        }
        #endregion
    }
}
