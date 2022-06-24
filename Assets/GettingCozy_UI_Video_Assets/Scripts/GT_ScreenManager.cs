using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GT_ScreenManager : MonoBehaviour
{
	#region Public Variables
	public GameObject optionsScreen;
	public GameObject labScreen;
	public GameObject startScreen;
	#endregion

	#region Private Variables
	private int curScreenID = 0;
	private Animator curAnim;
	#endregion

	#region UI Actions
	public void SwitchScreens(int aID)
	{
		curScreenID = aID;
		if(!curAnim)
		{
			curAnim = GetComponent<Animator>();
		}
		if(curAnim)
		{
			curAnim.SetBool("IsActive", false);
		}
	}

	public void RestMainMenu()
	{
		if(curAnim)
		{
			curAnim.SetBool("IsActive", true);
		}
	}

	public void AnimSwitch()
	{
		Debug.Log ("Reached End of Animation...");
		switch(curScreenID)
		{
			case 0:
				if(optionsScreen)
				{
					optionsScreen.SetActive(true);
				}
				break;
				
			case 1:
				if(labScreen)
				{
					labScreen.SetActive(true);
				}
				break;
				
			case 2:
				if(startScreen)
				{
					startScreen.SetActive(true);
				}
				break;
				
			default:
				break;
		}
	}
	#endregion
}
