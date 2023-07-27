
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _6._Generics.Models
{
    public abstract class Generic
    {
        public abstract List<string> Teams{ get; set; }

        public abstract void AddTeam(string team);
        
        public abstract void RemoveTeam(string team);

        public abstract void ShowTeams();
          
    }
}
