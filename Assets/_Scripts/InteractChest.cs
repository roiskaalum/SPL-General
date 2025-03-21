using UnityEngine;

public class InteractChest : Interactable
{
    public Canvas canvas;
    public string StateName = "TreasureChest-open";
    public override void Awake()
    {
        base.Awake();
        animatorStateName = StateName;
        canvas.enabled = false;
    }

    public void Update()
    {
        if (isInRange && Input.GetKeyDown(KeyCode.F))
        {
            Toggle(animatorStateName);
            canvas.enabled = false;
        }
    }

    public override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);
        canvas.enabled = true;
    }

    public override void OnTriggerExit(Collider other)
    {
        base.OnTriggerExit(other);
        canvas.enabled = false;
    }

    public override void Toggle(string animatorStateName)
    {
        base.Toggle(animatorStateName);
    }
}
