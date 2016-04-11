using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour
{
	void OnTriggerEnter(Collider co)
	{
		if (co.name == "Player")
			UnityEngine.SceneManagement.SceneManager.LoadScene ("foggy2");
	}
}