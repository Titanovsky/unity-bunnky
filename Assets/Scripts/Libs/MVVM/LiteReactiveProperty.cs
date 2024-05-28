using System;

namespace Libs.MVVM
{
	public class LiteReactiveProperty<T>
	{
		public event Action<T> OnPropertyChanged;

		private T _value;
		public T Value 
		{
			get 
			{ 
				return _value; 
			}

			set 
			{
				_value = value;

				OnPropertyChanged?.Invoke(_value);
			}
		}
	}
}