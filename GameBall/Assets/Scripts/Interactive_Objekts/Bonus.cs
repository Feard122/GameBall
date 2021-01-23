using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace GameBall
{
    public sealed class Bonus : InteractiveObject, IFlay, IFlicker, IEquatable<Bonus>
    {
        #region Field

        public int Point;
        private Material _material;
        private float _lengthFlay;        
        #endregion


        #region UnityMethod
        private void Awake()
        {
            _material = GetComponent<Renderer>().material;
            _lengthFlay = Random.Range(1.0f, 3.0f);           
        }
        #endregion


        #region Method

        protected override void Interaction()
        {
            _view.Display(Point);
           
        }

        public void Flay()
        {
            transform.localPosition = new Vector3(transform.localPosition.x,
                Mathf.PingPong(Time.time,_lengthFlay),
                transform.localPosition.z);
        }

        public void Flicker()
        {
            _material.color = new Color(_material.color.r, _material.color.g, _material.color.b,
                Mathf.PingPong(Time.time, 1.0f));
        }

      

        public bool Equals(Bonus other)
        {
            return Point == other.Point;
        }
        #endregion
    }
}
