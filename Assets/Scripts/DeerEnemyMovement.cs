using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeerEnemyMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 25f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Food"))
        {
            Destroy(gameObject);
        }
    }
}
