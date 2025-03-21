using UnityEngine;

public class InteractDoor : Interactable
{
    public Interactable interactable;
    private bool hasInteracted = false;
    public string StateName = "Dooropen";

    public override void Awake()
    {
        base.Awake();
        animatorStateName = StateName;
    }

    public void Update()
    {
        if(interactable.isInRange && !hasInteracted)
        {
            Toggle(animatorStateName);
        }
    }

    public override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);
    }

    public override void OnTriggerExit(Collider other)
    {
        base.OnTriggerExit(other);
        hasInteracted = false;
    }

    public override void Toggle(string animatorStateName)
    {
        base.Toggle(this.animatorStateName);
        hasInteracted = true;
    }

}
