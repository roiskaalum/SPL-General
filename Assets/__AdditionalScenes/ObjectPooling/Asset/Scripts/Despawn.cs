using UnityEngine;

public class Despawn : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        PooledObject pooledObject = collision.gameObject.GetComponent<PooledObject>();
        if(pooledObject != null)
        {
            pooledObject.Release();
        }
    }
}
