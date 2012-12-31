using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BodyByKurt.Models;

namespace BodyByKurt.Service.Interface
{
    public interface ITipSvc
    {
        List<Tip> selectAllTips();
        List<Tip> searchTips(Tip obj);
        Tip selectTip(String key);
        Boolean insertTip(Tip obj);
        Boolean updateTip(Tip obj);
        Boolean deleteTip(Tip obj);
    }
}
