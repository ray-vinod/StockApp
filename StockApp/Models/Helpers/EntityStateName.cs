using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;

namespace StockApp.Models.Helpers
{
    public class EntityStateName
    {
        public static string DisplayStates(IEnumerable<EntityEntry> entries)
        {
            string state = "";
            foreach (var entry in entries)
            {
                Console.WriteLine($"Entity: {entry.Entity.GetType().Name}," +
                    $"              State: { entry.State.ToString()}");
                state = entry.State.ToString();
            }
            return state;
        }
    }
}
