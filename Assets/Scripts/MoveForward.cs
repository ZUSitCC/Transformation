using UnityEngine;

public class MoveForward : MonoBehaviour
{
    private void Update()
    {
        transform.Translate(Vector3.forward);
    }
}
