using NodeCanvas.Framework;
using ParadoxNotion.Design;
using System;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class TrashPlaceAT : ActionTask {

        public GameObject trash;

		public Transform robotTransform;

		private Vector3 trashSpawnPos;

		public BBParameter <float> ableToPlaceBlock; 

        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit() {
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {

			//Setups where to spawn trash
				trashSpawnPos = new Vector3(robotTransform.position.x, robotTransform.position.y, robotTransform.position.z);
			
			//Creates trash prefab into the scene
				GameObject.Instantiate(trash, trashSpawnPos, Quaternion.identity);

			//reset ablity to place block
				ableToPlaceBlock = 0;

			//ends action
				EndAction(true);
			
		}

		//Called once per frame while the action is active.
		protected override void OnUpdate() {
			
		}

		//Called when the task is disabled.
		protected override void OnStop() {
			
		}

		//Called when the task is paused.
		protected override void OnPause() {
			
		}
	}
}