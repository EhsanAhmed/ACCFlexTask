using ACCFlexTask.Models;
using System.Collections.Generic;
using System.Linq;

namespace ACCFlexTask.Repository
{
    public class GenderRepository : IGender
    {
        Context context;
        public GenderRepository (Context _context)
        {
            context = _context;
        }
        public List<Gender> GetAll()
        {
            return context.Genders.ToList();
        }
    }
}
