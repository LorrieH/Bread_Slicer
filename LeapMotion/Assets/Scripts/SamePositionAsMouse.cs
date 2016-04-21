using UnityEngine;
using System.Collections;

public class SamePositionAsMouse : MonoBehaviour {

    float mousex;
    float mousey;
    Vector3 mouseposition;
    void Update () {
        mouseposition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseposition.z = transform.position.z;
        transform.position = mouseposition;
    }
}
