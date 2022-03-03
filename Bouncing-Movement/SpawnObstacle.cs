using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{
    public Vector2 rangeX, rangeY;
    private float randX, randZ, randRot;
    public float floorHeight = 0.5f;

    void Start()
    {
        randX = Random.Range(rangeX.x, rangeX.y);
        randZ = Random.Range(rangeY.x, rangeY.y);
        randRot = Random.Range(0, 360);
        transform.position = new Vector3(randX, floorHeight, randZ);
        this.gameObject.transform.Rotate(0, randRot, 0);
    }
}
