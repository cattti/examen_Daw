using System;
using examen.Models.Base;

namespace examen.Models
{
	public class Actor : BaseEntity
	{
		public string? FirstName { get; set; }

		public string? LastName { get; set; }

		public int? Age { get; set; }


		public ICollection<Actor_Film> Actors_Films { get; set; }
	}
}

