using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BudgeBuddy.Models
{
	public class GoalList
	{
		public int GoalListId { get; set; }

		[Required]
		public string UserId { get; set; }

		[Required]
		public string Title { get; set; }

		public virtual List<GoalItem> Goals { get; set; }
	}
}