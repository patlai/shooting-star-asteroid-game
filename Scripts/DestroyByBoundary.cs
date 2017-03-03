using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByBoundary : MonoBehaviour {
	//private void OnTriggerEnter(Collider other)
	//{
	//	Object.Destroy(other.gameObject.transform.parent.gameObject);
	//}

	void OnTriggerExit(Collider other)
	{
		Destroy(other.gameObject);
	}
}
