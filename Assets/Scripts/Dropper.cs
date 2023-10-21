using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private int timeDeadLine = 3;
    private Rigidbody rb;
    private MeshRenderer _renderer;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        _renderer = GetComponent<MeshRenderer>();
    }

    void Start()
    {
        _renderer.enabled = false;
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeDeadLine)
        {
            rb.useGravity = true;
            _renderer.enabled = true;
        }
    }
}
