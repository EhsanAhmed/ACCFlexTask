using ACCFlexTask.Models;
using System.Collections.Generic;

namespace ACCFlexTask.Repository
{
    public interface IGender
    {
        List<Gender> GetAll();
    }
}
