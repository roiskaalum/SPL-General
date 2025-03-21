using System.Collections;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    [SerializeField] private ObjectPool objectPool;
    [SerializeField] private float waitTime = 0.5f;
    private bool toggle = false;

    public void Spawn()
    {
        PooledObject pooledObject = objectPool.GetPooledObject();
        pooledObject.transform.position = transform.position;
        pooledObject.gameObject.SetActive(true);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Spawn();
            WaitABit();
        }

        if(Input.GetKeyDown(KeyCode.T))
        {
            toggle = !toggle;
        }

        if (toggle)
        {
            Spawn();
            FracSec();
        }
    }

    private IEnumerator WaitABit()
    {
        yield return new WaitForSeconds(waitTime);
    }

    private IEnumerator FracSec()
    {
        yield return new WaitForSeconds(0.1f);
    }
}
