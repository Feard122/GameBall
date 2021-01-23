using System;
using UnityEngine;
using Random = UnityEngine.Random;


namespace GameBall
{
    public abstract class InteractiveObject : MonoBehaviour, IInteractable, IComparable<InteractiveObject>
{
        #region Field

        protected IView _view;
        public event Action<InteractiveObject> OnDestroyChange;
        public bool IsInteractable { get; } = true;
        #endregion


        #region UnityMethod

        private void OnTriggerEnter(Collider other)
        {
            if (!IsInteractable || !other.CompareTag("Player"))
            {
                return;
            }
            Interaction();
            OnDestroyChange?.Invoke(this);
            Destroy(gameObject);
        }
        #endregion


        #region Method

        protected abstract void Interaction();

        private void Start()
        {
            ((IAction)this).Action();
        }

        void IAction.Action()
        {
            if (TryGetComponent(out Renderer renderer))
            {
                renderer.material.color = Random.ColorHSV();
            }
        }

        public void Initialization(IView view)
        {
            _view = view;
            if (TryGetComponent(out Renderer renderer))
            {
                renderer.material.color = Color.cyan;
            }
        }

        public int CompareTo(InteractiveObject other)
        {
            return name.CompareTo(other.name);
        }
        #endregion
    }
}
