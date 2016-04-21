using UnityEngine;
using System.Collections;

public class BreadSpawner : MonoBehaviour {

    [SerializeField]
    private GameObject baguette;
    [SerializeField]
    private float throwForceY = 30f;
    private Vector3 throwForce;

    void Start()
    {
        throwForce = new Vector3(0f, throwForceY, 0f);
        InvokeRepeating("SpawnBread", 0.5f, Random.Range(1,4));
    }

    void SpawnBread()
    {
        for (byte i = 0; i < Random.Range(1,3); i++)
        {
            GameObject Bread = Instantiate(baguette, new Vector3(Random.Range(10, 30), Random.Range(-25, -35), -40), Random.rotation) as GameObject;
            Bread.GetComponent<Rigidbody>().AddForce(throwForce, ForceMode.Impulse);
        }
    }

}
