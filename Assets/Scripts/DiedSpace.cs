using UnityEngine;

public class DiedSpace : MonoBehaviour
{
    public GameObject respawn;
    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Player"){
            other.transform.position = respawn.transform.position;
        }
    }
}