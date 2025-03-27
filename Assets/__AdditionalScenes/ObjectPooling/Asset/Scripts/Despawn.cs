using UnityEngine;

public class Despawn : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        PooledObject pooledObject = collider.gameObject.GetComponent<PooledObject>();
        Debug.Log(pooledObject);
        if (pooledObject != null)
        {
            Debug.Log("Entered");
            pooledObject.Release();
        }
    }
}
