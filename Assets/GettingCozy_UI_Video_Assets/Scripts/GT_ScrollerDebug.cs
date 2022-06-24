using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GT_ScrollerDebug : MonoBehaviour 
{

	public ScrollRect scroller;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(scroller)
		{
			Debug.Log (scroller.horizontalNormalizedPosition);
		}
	}
}
