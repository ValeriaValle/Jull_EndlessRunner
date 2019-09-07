using UnityEngine;
using UnityEngine.Events;

//Usar este script principalmente como medio para invocar UnityEvents desde AnimationEvents
//haciendo uso de la funcion InvokeEvent() con el índice correspondiente

public class EventsSummoner : MonoBehaviour
{
    public UnityEvent[] Events;

    public void InvokeEvent(int eventIndex)
    {
        if (Events[eventIndex] != null)
        {
            Events[eventIndex].Invoke();
        }
        else
        {
            Debug.Log("Event " + eventIndex + " not found");
        }
    }
}
