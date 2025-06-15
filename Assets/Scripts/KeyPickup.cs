using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    public static class GameVariables
    {
        public static int Keycount;
    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name== "First Person Controller")
        {
            GameVariables.Keycount += 1;
            Destroy(gameObject);
        }
    }
}
