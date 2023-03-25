﻿using System;
using System.Collections.Generic;

namespace Q1.Models;

public partial class Genre
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public virtual ICollection<Movie> Movies { get; } = new List<Movie>();

	public override string ToString()
	{
		return Title;
	}
}
