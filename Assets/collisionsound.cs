using UnityEngine;

public class collisionsound : MonoBehaviour
{
	public AudioSource PlayerGunshot;


	// Use this for initialization
	void Start()
	{
		PlayerGunshot = GetComponent<AudioSource>();
		SetAudio();
	}

	// Update is called once per frame
	void Update()
	{

	}
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "Coin")
		{
			SetAudio();
		}
	}
	void SetAudio()
	{
		PlayerGunshot.Play();
	}
}