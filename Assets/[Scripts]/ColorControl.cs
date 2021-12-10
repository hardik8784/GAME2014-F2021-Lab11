using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ColorControl : MonoBehaviour
{
    public Color color;
    public List<SpriteRenderer> renderers;

    
    // Start is called before the first frame update
    void Start()
    {
        renderers = GetComponentsInChildren<SpriteRenderer>().ToList();
        ChangeColour(this.color);
    }



    private void ChangeColour()
    {
        foreach (var renderer in renderers)
        {
            renderer.material.SetColor("_Color", this.color);
        }
    }

    private void ChangeColour(Color color = new Color())
    {
        foreach(var renderer in renderers)
        {
            renderer.material.SetColor("_Color", color);
        }
    }
}
