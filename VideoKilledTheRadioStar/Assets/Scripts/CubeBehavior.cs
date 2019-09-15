using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehavior : MonoBehaviour
{

	//public GameObject []  ScreenCube;
	//public GameObject[] cubes; 

	public GameObject CubePrefab;

	GameObject[] Cubeclones = new GameObject[20];

	//public GameObject[] cubes;
	private int numofCubes = 10;


	public int CountDownTime;
	public int RevealTime = 5;

	private float timer;
	private int cloneIndex;



	// Use this for initialization
	void Start()
	{


		

		for (int i = 0; i < 20; i++)
		{
			Cubeclones[i] = Instantiate(CubePrefab,
				new Vector3((transform.position.x * i * -0.15f), transform.position.y, 0f),
				Quaternion.identity) as GameObject;
			//cubes [i].SetActive(true);
			//CubePrefab.SetActive(true);
		}

		print((Cubeclones.Length));
		cloneIndex = Cubeclones.Length;

	}


	// Update is called once per frame
	void Update()
	{
			
		if (timer > 0)
		{
			//print(timer);
			timer -= Time.deltaTime;
			

			//else if (Input.GetKeyUp(KeyCode.Space))
			//{
			//	timer = 1; 
			//}

		}

		else
		{
			Destroy((Cubeclones[cloneIndex - 1]));
			cloneIndex--;
			timer = 1;
		}
		
		if (Input.GetKeyDown(KeyCode.Space) && cloneIndex != 0)
		{
			//cloneIndex += 1; 
			//print(cloneIndex);
			timer = 5;
			/*for (int i = 0; i < 1; i++)
			{
				Cubeclones [i] = Instantiate(CubePrefab, new Vector3((transform.position.x*i*-0.15f),
					transform.position.y,0f ), Quaternion.identity) as GameObject;
				//cubes [i].SetActive(true);
			}*/
		}


		/*if (Input.GetKey(KeyCode.Space) && cloneIndex != 0)
		{
			cloneIndex += 1; 
			
			for (int i = 0; i < 1; i++)
			{
				Cubeclones [i] = Instantiate(CubePrefab, new Vector3((transform.position.x*i*-0.15f),
					transform.position.y,0f ), Quaternion.identity) as GameObject;
				//cubes [i].SetActive(true);
				//CubePrefab.SetActive(true);
			}
		}

		else
		{
			timer = 1; 
		}*/
		
		
		
	}

	
}


