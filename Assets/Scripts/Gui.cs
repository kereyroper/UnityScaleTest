using UnityEngine;
using System.Collections;

public class Gui : MonoBehaviour
{
	public ScaleTester scaleTester;

	void OnGUI () {
		GUILayout.Label("Current object count: " + scaleTester.CurrentObjectCount);
		if (GUILayout.Button("Scale Up")) {
			scaleTester.ScaleUp();
		}
		if (GUILayout.Button("Scale Down")) {
			scaleTester.ScaleDown();
		}
	}
}
