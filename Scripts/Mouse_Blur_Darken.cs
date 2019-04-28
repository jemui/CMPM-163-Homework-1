/* Mouse_Blur_Darken.cs 
 * 
 * Use the A/S key to increase/decrease blurriness (Range is 0.0 to 50.0)
 * Use the Z/X key to increase/decrease the difference effect (Range is 0.0 to 1.0)
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_Blur_Darken : MonoBehaviour
{
    Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();

        rend.material.shader = Shader.Find("Custom/Blur");
    }

    // Update is called once per frame
    void Update()
    {
        float steps = rend.material.GetFloat("_Steps");
        float diff = rend.material.GetFloat("_Difference");

        // Press A to increase steps (blurriness)
        if (Input.GetKeyDown(KeyCode.A) && rend.material.GetFloat("_Steps") < 50.0) 
        {
            steps++;
            rend.material.SetFloat("_Steps", steps);
            Debug.Log("Increase Steps: " + steps);
        } else if(Input.GetKeyDown(KeyCode.A) && rend.material.GetFloat("_Steps") >= 50.0) {
            rend.material.SetFloat("_Steps", 50.0f);
            Debug.Log("Increase Steps: " + steps);
        }

        // Press S to decrease steps (blurriness)
        if (Input.GetKeyDown(KeyCode.S) && rend.material.GetFloat("_Steps") > 0.0) 
        {
            steps--;
            rend.material.SetFloat("_Steps", steps);
            Debug.Log("Decrease Steps: " + steps);;
        } else if(Input.GetKeyDown(KeyCode.S) && rend.material.GetFloat("_Steps") <= 0.0) {
            rend.material.SetFloat("_Steps", -1.0f);
            Debug.Log("Decrease Steps: " + steps);
        }

        // Press D to increase difference effect
        if (Input.GetKeyDown(KeyCode.Z) && rend.material.GetFloat("_Difference") < 1.0) 
        {
            diff+= 0.1f;
            rend.material.SetFloat("_Difference", diff);
            Debug.Log("Increase Difference: " + diff);
        } 
        else if(Input.GetKeyDown(KeyCode.Z) && rend.material.GetFloat("_Difference") >= 1.0) {
            rend.material.SetFloat("_Difference", 1.0f);
            Debug.Log("Increase Difference: " + diff);
        }

        // Press F to decrease difference effect
        if (Input.GetKeyDown(KeyCode.X) && rend.material.GetFloat("_Difference") > 0.0) 
        {
            diff-= 0.1f;
            rend.material.SetFloat("_Difference", diff);
            Debug.Log("Decrease Difference: " + diff);
        } 
        else if(Input.GetKeyDown(KeyCode.X) && rend.material.GetFloat("_Difference") <= 0.0) {
            rend.material.SetFloat("_Difference", 0.0f);
            Debug.Log("Decrease Difference: " + diff);
        }
    }
}