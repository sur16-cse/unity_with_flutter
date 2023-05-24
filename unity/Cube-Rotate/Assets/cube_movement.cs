using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_movement : MonoBehaviour
{
    public Vector3 RotateAmount;
    public int CutSpeed;

    void Update()
    {
        if (!float.IsNaN(RotateAmount.x) && !float.IsNaN(RotateAmount.y) && !float.IsNaN(RotateAmount.z))
        {
            transform.Rotate(RotateAmount * Time.deltaTime );
        }
        else
        {
            Debug.LogError("Invalid rotation values detected. Check the RotateAmount vector.");
        }
    }
}
