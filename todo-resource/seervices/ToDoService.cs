using System.Reflection.Emit;
using Microsoft.AspNetCore.Mvc;




    public static class TodoService
    {
          
        public static List<ToDO> GetToDOs()
        {
            return new List<ToDO>
            {
                new (1, "Learn .NET is fun", false),
                new (2, "Build API and see how good ", true),
                new (3, "Test Application", false),
                new (4, "Service is working", false),
            };
        }
    }

