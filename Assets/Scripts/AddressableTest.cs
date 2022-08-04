using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class AddressableTest : MonoBehaviour
{
    public string Name;

    // Start is called before the first frame update
    async void Start()
    {
        var res = await Addressables.LoadAssetAsync<GameObject>(Name).Task;
        Instantiate(res);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
