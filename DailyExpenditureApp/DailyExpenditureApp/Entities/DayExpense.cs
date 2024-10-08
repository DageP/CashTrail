﻿namespace DailyExpenditureApp.Entities
{
    public class DayExpense
    {
        public DateOnly Date {  get; set; }
        public Expense[] Expenditure { get; set; }
        public int Total { get; set; }
    }
}