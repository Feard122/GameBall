using UnityEngine;

namespace GameBall
{
    public class CameraController : MonoBehaviour
    {
        #region Field
        [SerializeField] private PlayerController _player;
        private Vector3 _offset;
        #endregion

        #region UnityMethod
       private void Start()
        {
            _offset = transform.position - _player.transform.position;
        }
                
        private void LateUpdate()
        {
            transform.position = _player.transform.position + _offset;
        }
        #endregion
    }
}