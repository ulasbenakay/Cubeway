using UnityEngine;


public class Credits : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit(); // bu kod oyunu export ttiğimizde çalışır. O nedenle çalıştığını anlamak için debug var.
    }
}
