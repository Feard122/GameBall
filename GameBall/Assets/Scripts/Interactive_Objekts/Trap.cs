using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace GameBall
{
    public sealed class Trap : InteractiveObject, IFlay, IRotation
    {
        #region Field

        private float _lengthFlay;
        private float _speedRotation;
        #endregion


        #region UnityMethod

        private void Awake()
        {
            _lengthFlay = Random.Range(1.0f, 2.0f);
            _speedRotation = Random.Range(20.0f, 50.0f);
        }
        #endregion


        #region Method

        protected override void Interaction()
        {
            // Destroy player
        }

        public void Flay()
        {
            transform.localPosition = new Vector3(transform.localPosition.x,
                Mathf.PingPong(Time.time, _lengthFlay),
                transform.localPosition.z);
        }

        public void Rotation()
        {
            transform.Rotate(Vector3.up * (Time.deltaTime * _speedRotation), Space.World);
        }
        #endregion
    }
}