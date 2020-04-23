using System;


namespace Aufgabe_9
{
    public class Person
    {
        public event Action<string> NameChanged;


		private string _firstName;
		public string FirstName
        {
            get => _firstName;
			set
			{
                _firstName = value;
				NameChanged?.Invoke(value);
			}
		}

		private string _lastName;
		public string LastName
		{
			get => _lastName;
			set
			{
                _lastName = value;
				NameChanged?.Invoke(value);
			}
		}

	}
}
