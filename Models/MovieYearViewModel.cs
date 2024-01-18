using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models;

public class MovieYearViewModel
{
    public List<Movie>? Movies { get; set; }
    public SelectList? ReleaseDate { get; set; }
    public string? MovieReleaseDate { get; set; }
    public string? SearchString { get; set; }
}