using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UpdateNIID.Data;
using UpdateNIID.Model;
using UpdateNIID.Repositories;


namespace UpdateNIID.Console
{
    public class PushABSMV
    {
        private UpdateNIID.Data.MotorDetailsRepository absData;
        private UpdateNIID.Data.MessageLog absMsg;
        private UpdateNIID.Data.Service req = new Service();

        //constructor
        public PushABSMV()
        {
            
            absData = new MotorDetailsRepository();
            absMsg = new MessageLog();
            //absData.createSchema();
          

            IList<MotorDetailsOnline> MotorData = absData.MotorDetails();
            Int64 cnt = 0;
            string m;
            try {
                foreach (MotorDetailsOnline md in MotorData)
                {
                    if (md.Status != "P") 
                    {
                        string returnvalue = req.Vehicle_Policy_Push(md.Username, md.Password, md.NiaNaicomID, md.PolicyNo,
                           md.InsuredName, md.ContactAddress, md.GSMNo, md.Email, md.EffectiveCoverDate, md.ExpirationDate, md.TypeOfCover, md.VehicleCategory,
                           md.EngineNo, md.ChasisNo, md.VehicleColor, md.YearofMake, md.VehicleMake, md.RegistrationNo, "", md.VehicleType, md.EngineCapacity,
                           md.VehicleModel, md.SumAssured, md.Premium, md.CoverNoteNo, md.CertificateNo, md.GeographicalZone);


                        if (returnvalue == "Successful")
                        {
                            cnt = cnt + 1;
                            md.Status = "P";
                            md.ProcessDate = DateTime.Now;
                        }
                        md.ReturnMessage = returnvalue;
                        absData.Save(md);

                    }

                }
                m = cnt.ToString() + " records out of " + MotorData.Count.ToString() + " uploaded unto NIID";
                absMsg.MsgLog(m);
                

            }
            catch(Exception x){
                absMsg.MsgLog( "Error!: " + x.Message);
            
            }
          }



            //Console.Write("Wow, NIID here I come!");
            //Console.Read();
        }




    }

