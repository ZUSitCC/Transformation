using UnityEngine;

public class MoveToLook : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        transform.Translate(transform.forward * _speed * Time.deltaTime);
    }
}
