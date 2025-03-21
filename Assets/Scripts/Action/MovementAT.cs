using NodeCanvas.Framework;
using ParadoxNotion.Design;
using System;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class MovementAT : ActionTask {

        public BBParameter<float> ableToPlaceBlock;
        
		//Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit() {
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
            
        }

		//Called once per frame while the action is active.
		protected override void OnUpdate()
		{

			//Player Moving Foward
			if (Input.GetKey(KeyCode.W))
			{
				agent.transform.position += Vector3.forward * Time.deltaTime;
			}
			//Player Moving Down
			else if (Input.GetKey(KeyCode.S))
			{
				agent.transform.position += Vector3.back * Time.deltaTime;
			}
			//Player Moving Left
			else if (Input.GetKey(KeyCode.A))
			{
				agent.transform.position += Vector3.left * Time.deltaTime;
			}
			//Player Moving Right
			else if (Input.GetKey(KeyCode.D))
			{
				agent.transform.position += Vector3.right * Time.deltaTime;
			}

            else if (Input.GetKey(KeyCode.Space))
            {
                ableToPlaceBlock = 1;
				EndAction(true);
            }

        }
		//Called when the task is disabled.
		protected override void OnStop() {
			
		}

		//Called when the task is paused.
		protected override void OnPause() {
			
		}
	}
}