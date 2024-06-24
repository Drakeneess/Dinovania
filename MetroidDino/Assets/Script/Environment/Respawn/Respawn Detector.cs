using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnDetector : MonoBehaviour
{
    public Canvas indicator;
    public bool playerInArea=false;
    // Start is called before the first frame update
    void Start()
    {
        indicator=GetComponentInChildren<Canvas>();
        indicator.enabled=false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            indicator.enabled=true;
            playerInArea=true;
        }
    }
    private void OnTriggerExit(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            indicator.enabled=false;
            playerInArea=false;

        }
    }
}
