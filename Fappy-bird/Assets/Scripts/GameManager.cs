using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject pipePrefeb;
    [SerializeField] private float  pipetimerinterval;
   private void Start()
    {
        
    }

    private IEnumerator CallSpawner()
    {
                
        yield return new WaitForSeconds(pipetimerinterval);
        Instantiate(pipePrefeb);
        
    }
}
