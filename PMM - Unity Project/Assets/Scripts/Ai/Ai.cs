using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;

public class Ai : MonoBehaviour
{
    public Transform follow;
     void Start()
    {
      
    }
    void Update()
    {
        GetComponent<UnityEngine.AI.NavMeshAgent>().destination = follow.transform.position;
    }
}
