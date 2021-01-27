using System;
using UnityEngine.Events;

[Serializable]
public abstract class InteractionLogic : UnityEvent<Interaction>
{

	public void Perform()
	{
		Interaction();
	}

	public abstract void Interaction();
}