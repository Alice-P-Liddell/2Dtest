using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    Transform tr;
    public float minX;
    public float maxX;
    public float speed;

    void Start()
    {
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        tr.Translate(-1 * Time.deltaTime * speed, 0, 0);

        if (tr.position.x <= minX)
        {
            tr.Translate(maxX * 2, 0, 0, Space.World);
        }
    }
}
