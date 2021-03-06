using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TerrainDestroyer"))
        {
            Destroy(this.gameObject);
        }
    }
}
