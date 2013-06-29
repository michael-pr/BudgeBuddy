using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace BudgeBuddy.Models
{
	public class GoalItemDto
	{
		public GoalItemDto() { }

		public GoalItemDto(GoalItem item)
		{
			GoalItemId = item.GoalItemId;
			Title = item.Title;
			Description = item.Description;
			Amount = item.Amount;
			IsRepeatable = item.IsRepeatable;
			IsNecessary = item.IsNecessary;
			IsDone = item.IsDone;
			DateToCompleteBy = item.DateToCompleteBy;
			GoalListId = item.GoalListId;
		}

		[Key]
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

		public int GoalListId { get; set; }

		public GoalItem ToEntity()
		{
			return new GoalItem
			{
				GoalItemId = GoalItemId,
				Title = Title,
				Description = Description,
				Amount = Amount,
				IsRepeatable = IsRepeatable,
				IsNecessary = IsNecessary,
				IsDone = IsDone,
				DateToCompleteBy = DateToCompleteBy,
				GoalListId = GoalListId
			};
		}
	}
}