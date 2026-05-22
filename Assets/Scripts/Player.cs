using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private Transform gunPosition;
    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Gun"))
        {
           other.GetComponent<Gun>().GrabGun(gunPosition); 
        }
    }

}
