using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackGround : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWidith;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        repeatWidith = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < startPos.x - repeatWidith)
        {
            transform.position = startPos;

        }
    }
}
