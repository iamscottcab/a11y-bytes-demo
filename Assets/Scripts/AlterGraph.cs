using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlterGraph : MonoBehaviour
{
    [SerializeField]
    private SpriteMask mask;
    
    private void Update()
    {
        mask.alphaCutoff = 1 - Input.GetAxis("A");
    }
}
