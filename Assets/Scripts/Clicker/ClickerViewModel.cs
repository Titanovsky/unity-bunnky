using Libs.MVVM;
using System;

public class ClickerViewModel
{
	#region Vars/Props
	private ClickerView _view;
	
	public LiteReactiveProperty<int> CountView { get; set; } = new() { Value = 0 };
	#endregion

	#region Logic
	public ClickerViewModel(ClickerView view) 
	{ 
		_view = view;
	}
	#endregion
}