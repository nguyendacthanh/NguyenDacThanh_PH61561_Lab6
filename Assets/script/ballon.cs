using System.Collections;
using UnityEngine;

public class ballon : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject ballons;
    
        private void Start()
    {

        StartCoroutine(spawn());
        
    }
  
    
    IEnumerator spawn() {

        while (true) {
            float randomTag = Random.Range(1,5);
            ballons = GameObject.FindGameObjectWithTag("" + randomTag);


            float viTriNgauNhien = Random.Range(-6.5f, 8f);
            Vector3 spawnPosition = new Vector3(viTriNgauNhien, -10f, 0f);

            Instantiate(ballons, spawnPosition, Quaternion.identity);
            yield return new WaitForSeconds(2f);
        }
        

    }
    
}
