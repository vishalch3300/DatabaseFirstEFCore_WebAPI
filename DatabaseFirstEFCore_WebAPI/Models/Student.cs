﻿using System;
using System.Collections.Generic;

namespace DatabaseFirstEFCore_WebAPI.Models;

public partial class Student
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Gender { get; set; }

    public int? Age { get; set; }

    public int? Standard { get; set; }
}
