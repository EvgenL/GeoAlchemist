using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mapbox.Examples
{
	public class CharacterMovement : MonoBehaviour
	{
		public Material[] Materials;
		public Transform Target;
		public Animator CharacterAnimator;
		public float Speed;
		AstronautMouseController _controller;
		void Start()
		{
			_controller = GetComponent<AstronautMouseController>();
		}

		void Update()
		{

		    if (_controller.enabled)// Because the mouse control script interferes with this script
			{
				return;
			}


		    Materials[0].SetVector("_CharacterPosition", transform.position);
		    Materials[1].SetVector("_CharacterPosition", transform.position);

            /*for (int i = 0; i < Materials.Length; i++) // Does not work either
		    {
		        Materials[i].SetVector("_CharacterPosition", transform.position);
            }*/

            /*foreach (var item in Materials)// Does not work
			{
				item.SetVector("_CharacterPosition", transform.position);
			}*/

            var distance = Vector3.Distance(transform.position, Target.position);
			if (distance > 0.1f)
			{
				transform.LookAt(Target.position);
				transform.Translate(Vector3.forward * Speed);
				CharacterAnimator.SetBool("IsWalking", true);
			}
			else
			{
				CharacterAnimator.SetBool("IsWalking", false);
			}
		}
	}
}