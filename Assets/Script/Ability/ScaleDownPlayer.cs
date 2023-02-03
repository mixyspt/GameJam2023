using System.Collections;
using System.Collections.Generic;
using GameJam.GameData;
using UnityEngine;

public class ScaleDownPlayer : MonoBehaviour
{
    private void OnTriggerEnter(Collider _col)
    {
        var _multiply = FindObjectOfType<ScaleSetting>().scaleDownMultiply;
            
        _col.gameObject.transform.localScale *= _multiply;
        
        Destroy(this.gameObject);
    }
}