using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class ThrowFood : MonoBehaviour
{
    [SerializeField] GameObject foodPrefab;
    [SerializeField] Transform spawnPoint;
    [SerializeField] private float throwPower = 30f;
    [SerializeField] private int timeoutDestructor = 3;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ThrowFoodProjectile();
        }
    }

    void ThrowFoodProjectile()
    {
        // Instantiate the projectile at the position and rotation of this transform
        GameObject clone = Instantiate(foodPrefab, spawnPoint.position, spawnPoint.rotation);

        Rigidbody rb = clone.GetComponent<Rigidbody>();
        if (rb != null )
        {
            rb.AddForce(spawnPoint.forward * throwPower, ForceMode.Impulse);
        }

        Destroy( clone, timeoutDestructor );
    }

}


