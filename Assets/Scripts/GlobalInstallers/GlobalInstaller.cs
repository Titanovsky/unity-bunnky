using Zenject;
using UnityEngine;

public class GlobalInstaller : MonoInstaller
{
	private void BindSomething()
	{
		//todo
	}

	#region Zenject
	public override void InstallBindings()
	{
		BindSomething();
	}
	#endregion
}