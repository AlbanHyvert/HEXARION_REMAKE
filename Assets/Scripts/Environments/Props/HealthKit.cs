using System.Net;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class HealthKit : MonoBehaviour
{
    [SerializeField] private int _healValue = 10;

    private void Start()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();

        rigidbody.isKinematic = true;
        rigidbody.useGravity = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerController player = other.GetComponent<PlayerController>();

        if(player != null)
        {
            player.SetHealingValue = _healValue;

            Destroy(gameObject);
        }
    }
}
