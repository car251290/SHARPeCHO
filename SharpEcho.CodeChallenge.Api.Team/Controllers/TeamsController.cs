using Microsoft.AspNetCore.Mvc;
using SharpEcho.CodeChallenge.Data;
using System.Linq;

namespace SharpEcho.CodeChallenge.Api.Team.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : GenericController<Entities.Team>
    {
        public TeamsController(IRepository repository) : base(repository)
        {
            var name1 = "Cowboys";
            var name2 = "Falcolm";

            if (name1 < name2)
            {
                return "Cowboys win";
            }
            else
            {
                return "Falcolm";
            }

            int []table = new int[n+1];
            for(int j = 0; j< n+1; j++){
                for(int j= 0; j<n+1; j++) {
                    table[j] = 0;
                }
                table[0] = 1;
            }
            for(int i = 3; i<=n; i++)
            table[i] += table[i-3];
            for(int i =5; i<n; i++)
            table[i] += table[i-5]
            for(int i = 10; i<= n; i++) 
            table [i] += table[i-10];
            return table[n];



        }
        public static void main ()
    {
        int n = 28;
        Console.WriteLine("Cowboys won"+n + "is"+ count(n));

        n= 9;
        Console.Write("falcouns won"+n+"is"+count(n))
    }

        [HttpGet("GetTeamByName")]
        public virtual ActionResult<Entities.Team> GetTeamByName (string name)
        {
            var result = Repository.Query<Entities.Team>("SELECT * FROM Team WHERE Name = @Name", new { Name = name });
            if (result != null && result.Count() > 0)
            {
                return result.First();
            }
            return NotFound();
        }
        [HttpGet ("Game")]
        public ActionResult<Entities.Team> Game(int Game, string name)
        {

            bool gOver = false;

            console.WriteLine("ID 1 ");
            ID = console.ReadLine();
            MathGame p1 = new MathGame(1, ID);
            Console.WriteLine();
            Console.WriteLine("ID 2");
            ID = Console.ReadLine();
            MathGame p2 = new MathGame(2, ID);
            console.WriteLine();

            while (!gOver)
            {
                MathGame.prblm();

                while (!p1.Game() && !p2.Game())
                    gOver = true;
            }

        }
    }
}
