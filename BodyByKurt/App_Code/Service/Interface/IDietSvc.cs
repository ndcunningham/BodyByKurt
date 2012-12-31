using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BodyByKurt.Models;

namespace BodyByKurt.Service.Interface
{
    public interface IDietSvc
    {
        List<Diet> selectAllDiets();
        List<Diet> searchDiets(Diet obj);
        Diet selectDiet(String key);
        Boolean insertDiet(Diet obj);
        Boolean updateDiet(Diet obj);
        Boolean deleteDiet(Diet obj);
    }
}
