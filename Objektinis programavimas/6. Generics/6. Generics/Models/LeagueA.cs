
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _6._Generics.Models
{
    public class LeagueA : Generic
    {
       public override List<string> Teams { get; set; }

        public override void AddTeam(string team)
        {
            Teams.Add(team);
        }
        public override void RemoveTeam(string team)
        {
            Teams.Remove(team);
        }
        public override void ShowTeams()
        {
            foreach (string team in Teams) 
            {
                Console.WriteLine(team);
            }
        }
    }
}