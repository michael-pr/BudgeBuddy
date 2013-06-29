using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BudgeBuddy.Models
{
	public class GoalItemContext : DbContext
	{
		public GoalItemContext()
			: base("name=DefaultConnection")
		{
		}

		public DbSet<GoalItem> GoalItems { get; set; }
		public DbSet<GoalList> GoalLists { get; set; }
	}
}