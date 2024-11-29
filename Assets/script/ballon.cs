using System.Collections;
using UnityEngine;

public class ballon : MonoBehaviour
{
    public GameObject ballons,b2,b3,b4,b5;
    
        private void Start()
    {

        StartCoroutine(spawn());
        
    }
  
    
    IEnumerator spawn() {

        while (true) {
            
            


            float viTriNgauNhien = Random.Range(-6.5f, 8f);
            Vector3 spawnPosition = new Vector3(viTriNgauNhien, -10f, 0f);

            Instantiate(ballons, spawnPosition, Quaternion.identity);
            yield return new WaitForSeconds(2f);
        }
        

    }
    
}
