using UnityEngine;
using System.Collections;

public class IncreaseFlame : MonoBehaviour 
{
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject myPrefab;

    // This script will simply instantiate the Prefab when the game starts.
    void Start()
    {
        StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()
    {

        //yield on a new YieldInstruction that waits for 30 seconds.
        for(int i = 0; i<6; i++)
        {
            yield return new WaitForSeconds(15);
            Instantiate(myPrefab, new Vector3(0,0,0), Quaternion.identity);
        }

    }
}