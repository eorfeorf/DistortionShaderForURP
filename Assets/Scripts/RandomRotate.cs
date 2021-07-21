using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomRotate : MonoBehaviour
{
    private void Awake()
    {
        var x = Random.Range(0f, 360f);
        var y = Random.Range(0f, 360f);
        var z = Random.Range(0f, 360f);
        var rot = new Vector3(x, y, z);
        transform.Rotate(rot);
    }
}
