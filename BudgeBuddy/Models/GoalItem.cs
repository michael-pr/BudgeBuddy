using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BudgeBuddy.Models
{
	public class GoalItem
	{
		public int GoalItemId { get; set; }

		[Required]
		public string Title { get; set; }
		public string Description { get; set; }

		[Required]
		public double Amount { get; set; }

		public bool IsRepeatable { get; set; }
		public bool IsNecessary { get; set; }
		public bool IsDone { get; set; }

		public DateTime DateToCompleteBy { get; set; }

		[ForeignKey("GoalList")]
		public int GoalListId { get; set; }
		public virtual GoalList GoalList { get; set; }
	}
}