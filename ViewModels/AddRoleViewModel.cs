﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CSC273_NTebeje_Final_Project.ViewModels
{
	public class AddRoleViewModel
	{
		[Required]
		[Display(Name = "Role name")]
		public string RoleName { get; set; }
	}
}
