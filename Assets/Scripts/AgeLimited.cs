using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgeLimited : MonoBehaviour {

    private UIInput input;

	void Awake () {
        input = this.GetComponent<UIInput>();
	}
	
	public void OnAgeValueChanged()
    {
        int valueInt=int.Parse(input.value);

        if(valueInt<18)
        {
            input.value = "18";
        }
        if(valueInt > 120)
        {
            input.value = "120";
        }
    }
}
