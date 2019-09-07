using System.Collections.Generic;
using UnityEngine;

namespace UnityTools.Events
{
    [CreateAssetMenu(fileName = "MultipleEvent_", menuName = "Game Multiple Event")]
    public class GameEventMultiple : ScriptableObject
    {

        private readonly List<ElementListener> eventListeners = new List<ElementListener>();
        public void Raise()
        {
            for (int i = eventListeners.Count - 1; i >= 0; i--)
            {
                eventListeners[i].listener.OnEventRaised(eventListeners[i].index);
            }
        }

        public void RegisterListener(GameEventMultipleListener listener, int index)
        {
            if (eventListeners.Find(ltn => ltn.listener == listener) == null)
            {
                eventListeners.Add(new ElementListener(listener, index));
            }
        }

        public void UnregisterListener(GameEventMultipleListener listener, int index)
        {
            var count = eventListeners.RemoveAll(lmt => lmt.listener == listener && lmt.index == index);
        }
    }

    [System.Serializable]
    public class ElementListener
    {

        public GameEventMultipleListener listener;
        public int index = -1;
        public ElementListener(GameEventMultipleListener listener, int index)
        {
            this.listener = listener;
            this.index = index;
        }
    }
}

