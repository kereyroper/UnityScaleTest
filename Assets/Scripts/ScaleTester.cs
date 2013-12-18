using UnityEngine;

public class ScaleTester : MonoBehaviour
{
	public GameObject cubePrefab;
	public GameObject dynamicObjectRoot;

	private int scaleLevel;

	public void ScaleDown() {
		if (scaleLevel == 0) {
			return;
		}
		scaleLevel--;
		ClearObjects();
	}

	public void ScaleUp() {
		scaleLevel++;
		GenerateObjects();
	}

	private void ClearObjects() {
		var numObjects = ScaleToNumObjects(scaleLevel + 1) - ScaleToNumObjects(scaleLevel);
		var children = new GameObject[numObjects];
		for (int i = 0; i < numObjects; i++) {
			children[i] = dynamicObjectRoot.transform.GetChild(i).gameObject;
		}
		foreach (var child in children) {
			Destroy(child);
		}
	}

	private void GenerateObjects() {
		var numObjects = ScaleToNumObjects(scaleLevel) - ScaleToNumObjects(scaleLevel - 1);
		for (int i = 0; i < numObjects; i++) {
			var go = (GameObject)Instantiate(cubePrefab);
			go.transform.parent = dynamicObjectRoot.transform;
		}
	}

	private int ScaleToNumObjects(int level) {
		if (level == 0) {
			return 0;
		}
		return (int)Mathf.Pow(10, level-1);
	}

}
