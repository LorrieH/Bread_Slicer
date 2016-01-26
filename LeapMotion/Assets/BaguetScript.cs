using UnityEngine;
using System.Collections;

public class BaguetScript : MonoBehaviour {

    [SerializeField]
    private GameObject baguet;
    private Vector3 throwForce = new Vector3(0, 150, 0);

    void Start()
    {
        InvokeRepeating("SpawnBread", 0.5f, 6);
    }

    void SpawnBread()
    {
        for (byte i = 0; i < 4; i++)
        {
            GameObject Bread = Instantiate(baguet, new Vector3(Random.Range(10, 30), Random.Range(-25, -35), -32), Quaternion.identity) as GameObject;
            Bread.GetComponent<Rigidbody>().AddForce(throwForce, ForceMode.Impulse);
        }
    }

}
