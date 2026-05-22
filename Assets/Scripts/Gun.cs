using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField]
    private Animator animator;
    [SerializeField]
    private Rotate rotateScript;
    public void GrabGun(Transform gunPosition)
    {
        transform.SetParent(gunPosition);
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.identity;
        animator.Play("Grab", 0, 0f);
        rotateScript.canRotate = false;
        gameObject.GetComponent<Collider>().enabled = false;
    }

}
