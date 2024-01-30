using UnityEngine;

public class IncreaseInSize : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;

    private void Update()
    {
        transform.localScale += _speed * Time.deltaTime * Vector3.one;
    }
}