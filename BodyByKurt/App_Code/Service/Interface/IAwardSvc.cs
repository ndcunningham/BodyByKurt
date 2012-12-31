using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BodyByKurt.Models;

namespace BodyByKurt.Service.Interface
{
    public interface IAwardSvc
    {
        List<Award> selectAllAwards();
        List<Award> searchAwards(Award obj);
        Award selectAward(String key);
        Boolean insertAward(Award obj);
        Boolean updateAward(Award obj);
        Boolean deleteAward(Award obj);
    }
}
