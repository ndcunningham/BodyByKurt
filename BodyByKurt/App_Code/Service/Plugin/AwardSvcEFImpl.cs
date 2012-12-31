using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BodyByKurt.Models;
using BodyByKurt.Service.Interface;

namespace BodyByKurt.Service.Plugin
{
    public class AwardSvcEFImpl : IAwardSvc
    {
        public List<Award> selectAllAwards()
        {
            BodyByKurtContext db = new BodyByKurtContext();

            try
            {
                IQueryable<Award> AwardList = from Award in db.Awards
                                                    select Award;

                return AwardList.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public List<Award> searchAwards(Award obj)
        {
            BodyByKurtContext db = new BodyByKurtContext();

            try
            {
                IQueryable<Award> AwardList = from Award in db.Awards
                                                    where Award.Award_ID.StartsWith(obj.Award_ID)
                                                    || Award.First_Name.StartsWith(obj.First_Name)
                                                    || Award.Last_Name.StartsWith(obj.Last_Name)
                                                    orderby Award.Award_ID ascending
                                                    select Award;

                return AwardList.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public Award selectAward(String AwardId)
        {
            BodyByKurtContext db = new BodyByKurtContext();

            try
            {
                IQueryable<Award> AwardList = from Award in db.Awards
                                                    where Award.Award_ID == AwardId
                                                    select Award;

                return (AwardList.ToList())[0];
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public Boolean insertAward(Award obj)
        {
            using (BodyByKurtContext db = new BodyByKurtContext())
            {
                try
                {
                    db.Awards.Add(obj);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }

        public Boolean updateAward(Award obj)
        {
            using (BodyByKurtContext db = new BodyByKurtContext())
            {
                try
                {

                    IQueryable<Award> AwardList = from Award in db.Awards
                                                        where Award.Award_ID == obj.Award_ID
                                                        select Award;

                    if ((AwardList.ToArray()).Length > 0)
                    {
                        foreach (Award Award in AwardList)
                        {
                            Award.Award_ID = obj.Award_ID;
                            Award.First_Name = obj.First_Name;
                            Award.Last_Name = obj.Last_Name;
                        }

                        #region Database Submission with Rollback

                        try
                        {
                            db.SaveChanges();
                            return true;
                        }
                        catch (Exception ex)
                        {
                            return false;
                        }
                        #endregion
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }

        public Boolean deleteAward(Award obj)
        {
            using (BodyByKurtContext db = new BodyByKurtContext())
            {
                try
                {
                    IQueryable<Award> AwardList = from Award in db.Awards
                                                        where Award.Award_ID == obj.Award_ID
                                                        select Award;

                    if ((AwardList.ToArray().Length > 0))
                    {

                        db.Addresses.Remove((AwardList.ToArray())[0].Address);
                        db.Awards.Remove((AwardList.ToArray())[0]);
                        #region Database Submission

                        try
                        {
                            db.SaveChanges();
                            return true;
                        }
                        catch (Exception ex)
                        {
                            return false;
                        }

                        #endregion
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

    }
}
