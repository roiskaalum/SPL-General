using UnityEngine;

public class Interactable : MonoBehaviour
{
    public bool isInRange;
    protected BoxCollider boxCollider;
    protected Animator animator;
    public string animatorStateName;

    public virtual void Awake()
    {
        animator = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider>();
        isInRange = false;
    }

    public virtual void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player entered the trigger");
        isInRange = true;
    }

    public virtual void OnTriggerExit(Collider other)
    {
        Debug.Log("Player exited the trigger");
        isInRange = false;
        animator.SetBool("Open", false);
        animator.SetBool("Close", true);
    }


    public virtual void Toggle(string animatorStateName)
    {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName(animatorStateName))
        {
            animator.SetBool("Close", true);
            animator.SetBool("Open", false);
            Debug.Log("Object should've Played Open Animation");
        }
        else
        {
            animator.SetBool("Open", true);
            animator.SetBool("Close", false);
            Debug.Log("Object should've Played Close Animation");
        }
    }
}
