using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineManager : MonoBehaviour
{
    #region Editor
    private int initPoolCount;
    #endregion

    public static CoroutineManager Instance;

    private void Awake()
    {
        if (Instance != null)
            Destroy(gameObject);

        Instance = this;
    }

    public void QueueUserWorkItem(IEnumerator routine)
    {
        
    }
}
