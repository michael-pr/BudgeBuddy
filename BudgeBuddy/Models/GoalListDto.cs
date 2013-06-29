using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace BudgeBuddy.Models
{
	public class GoalListDto
	{
		public GoalListDto() { }

		public GoalListDto(GoalList list)
		{
			GoalListId = list.GoalListId;
			UserId = list.UserId;
			Title = list.Title;
			Goals = new List<GoalItemDto>();
			foreach (GoalItem item in list.Goals)
			{
				Goals.Add(new GoalItemDto(item));
			}
		}

		[Key]
		public int GoalListId { get; set; }

		[Required]
		public string UserId { get; set; }

		[Required]
		public string Title { get; set; }

		public virtual List<GoalItemDto> Goals { get; set; }

		public GoalList ToEntity()
		{
			GoalList goals = new GoalList
			{
				Title = Title,
				GoalListId = GoalListId,
				UserId = UserId,
				Goals = new List<GoalItem>()
			};
			foreach (GoalItemDto item in Goals)
			{
				goals.Goals.Add(item.ToEntity());
			}
			return goals;
		}
	}
}