using System;

namespace TodoProject.Models;
public class Todo
{

    public Guid Id { get; set; }
    public bool done { get; set; }
    public string title { get; set; }

}