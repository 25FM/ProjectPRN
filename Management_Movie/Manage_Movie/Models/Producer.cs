using System;
using System.Collections.Generic;

namespace Q1.Models;

public partial class Producer
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Movie> Movies { get; } = new List<Movie>();

	public override string ToString()
	{
		return Name;
	}
}
