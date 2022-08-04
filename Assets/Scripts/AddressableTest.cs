using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class AddressableTest : MonoBehaviour
{
    public string Name;
    private List<GameObject> lst = new List<GameObject>();
    // Start is called before the first frame update
    async void Start()
    {
        
    }

    private async void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            var res = await Addressables.LoadAssetAsync<GameObject>(Name).Task;
            lst.Add(res);
            Instantiate(res);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            while (lst.Count > 0)
            {
                var r = lst[0];
                lst.RemoveAt(0);
                Addressables.ReleaseInstance(r);
                break;
            }
         
        }   
    }

    
}
