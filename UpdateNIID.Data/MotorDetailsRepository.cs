using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UpdateNIID.Model;
using UpdateNIID.Repositories;
using NHibernate;

namespace UpdateNIID.Data
{
    public class MotorDetailsRepository : IABSDataRepository
    {
        private static ISession GetSession()
        {
            return SessionProvider.SessionFactory.OpenSession();
        }

        public void Save(MotorDetailsOnline saveObj)
        {
            using (var session = GetSession())
            {
                using (var trans = session.BeginTransaction())
                {
                    session.FlushMode = FlushMode.Commit;
                    session.SaveOrUpdate(saveObj);
                    trans.Commit();
                    session.Flush();
                    //}
                }
            }
        }
        public void Delete(MotorDetailsOnline delObj)
        {
            using (var session = GetSession())
            {
                using (var trans = session.BeginTransaction())
                {
                    session.Delete(delObj);
                    trans.Commit();
                }
            }
        }
        public IList<MotorDetailsOnline> MotorDetails()
        {
            using (var session = GetSession())
            {
                var pDet = session.CreateCriteria<MotorDetailsOnline>()

                                     .List<MotorDetailsOnline>();

                return pDet;
            }
        }
        public MotorDetailsOnline GetById(Int32? id)
        {
            using (var session = GetSession())
            {
                return session.Get<MotorDetailsOnline>(id);
            }
        }
        public MotorDetailsOnline GetById(String _key)
        {
            //the _key is an array of string values (3). Split into individual values and fill the parameters
            Char[] seperator = new char[] { ',' };
            string[] keys = _key.Split(seperator, StringSplitOptions.RemoveEmptyEntries);

            string hqlOptions = "from MotorDetailsOnline i where i.ebId = " + keys[0]
                              + " and i.MeterNo = '" + keys[1] + "'";

            using (var session = GetSession())
            {

                return (MotorDetailsOnline)session.CreateQuery(hqlOptions).UniqueResult();
            }
        }

        public void MoveData(MotorDetailsOnline md)
        {
            
        }
        public void createSchema() {
            SessionProvider.RebuildSchema();
        }

    }
}
