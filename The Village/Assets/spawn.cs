using UnityEngine;
using System.Collections;

public class spawn : MonoBehaviour
{

    public GameObject bob;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
            SpawnBob();

    }

    void SpawnBob()
    {

        // Where should we spawn Bob?
        Vector3 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        clickPosition.z = 0;

        // Now we can actually spawn a bob object
        Instantiate(bob, clickPosition, Quaternion.identity);

    }
}