using UnityEngine;
using System.Collections;

public class ScaleTester : MonoBehaviour
{
	public GameObject cubePrefab;
	public GameObject dynamicObjectRoot;

	private int scaleLevel;

	public void ScaleDown() {
		scaleLevel--;
	}

	public void ScaleUp() {
		scaleLevel++;
	}

}
