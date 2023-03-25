using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MovieStoreMvc.Models;

namespace WebApplication1.Models;

public partial class MovieStoreMvcContext : DbContext
{
	public MovieStoreMvcContext()
	{
	}

	public MovieStoreMvcContext(DbContextOptions<MovieStoreMvcContext> options)
		: base(options)
	{
	}

	public virtual DbSet<Genre> Genre { get; set; }

	public virtual DbSet<Movie> Movie { get; set; }

	public virtual DbSet<MovieGenre> MovieGenre { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		if (!optionsBuilder.IsConfigured)
		{
			var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
			optionsBuilder.UseSqlServer(config.GetConnectionString("conn"));
		}
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Genre>(entity =>
		{
			entity.ToTable("Genre");

			entity.Property(e => e.GenreName).HasMaxLength(255);
		});

		modelBuilder.Entity<Movie>(entity =>
		{
			entity.ToTable("Movie");

			entity.Property(e => e.Cast).HasMaxLength(255);
			entity.Property(e => e.Director).HasMaxLength(255);
			entity.Property(e => e.MovieImage).HasMaxLength(255);
			entity.Property(e => e.ReleaseYear).HasMaxLength(255);
			entity.Property(e => e.Title).HasMaxLength(255);
		});

		modelBuilder.Entity<MovieGenre>(entity =>
		{
			entity.ToTable("MovieGenre");

			entity.HasOne(d => d.Genre).WithMany(p => p.MovieGenres)
				.HasForeignKey(d => d.GenreId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_MovieGenre_Genre");

			entity.HasOne(d => d.Movie).WithMany(p => p.MovieGenres)
				.HasForeignKey(d => d.MovieId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_MovieGenre_Movie1");
		});

		OnModelCreatingPartial(modelBuilder);
	}

	partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
