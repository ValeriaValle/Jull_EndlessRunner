using UnityEngine;
using UnityEngine.Events;

namespace UnityTools.Events
{
    public class GameEventMultipleListener : MonoBehaviour
    {
        public EventList[] listEvents;

        private void OnEnable()
        {
            if (listEvents.Length > 0)
                for (int i = 0; i < listEvents.Length; i++)
                    listEvents[i].Event.RegisterListener(this, i);
        }

        private void OnDisable()
        {
            if (listEvents.Length > 0)
                for (int i = 0; i < listEvents.Length; i++)
                    listEvents[i].Event.UnregisterListener(this, i);
        }

        public void OnEventRaised(int i)
        {
            try
            {
                listEvents[i].Response.Invoke();
            }
            catch (System.Exception)
            {

                Debug.Log("se produjo un error en: " + listEvents[i].eventName + " en " + gameObject.name);
            }
        }
    }

    [System.Serializable]
    public struct EventList
    {
        [Header("(Opcional)")]
        public string eventName;
        public GameEventMultiple Event;
        public UnityEvent Response;
    }


}