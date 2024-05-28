using Libs.MVVM;
using System;

public class ClickerModel
{
	#region Vars/Props
	public LiteReactiveProperty<int> Count { get; set; } = new() { Value = 0 };
	#endregion

	#region Logic
	public ClickerModel()
    {
    }
    #endregion
}