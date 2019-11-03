using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer;

namespace Business_Logic_Layer
{
    public class BusinessLogicLayer
    {
        UserClass uc = new UserClass();
        PatientClass pc = new PatientClass();
        DoctorClass dc = new DoctorClass();
        SaleClass sc = new SaleClass();
        StaffClass stc = new StaffClass();
        MedicineClass mc = new MedicineClass();
        CabinClass cc = new CabinClass();
        others o = new others();


        public bool UserTable(int UserId,
            String UserName,
            String Password,
            String Role,
            int Mode)
        {
            try
            {
                bool result = false;
                int conn = uc.UserTable(UserId, UserName, Password, Role, Mode);
                if (conn > 0)
                    result = true;
                else
                    result = false;
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool PatientTable(int PatientId,
            int VisitorNo,
            String Title,
            String PatientName,
            String Address,
            int ContactNo,
            DateTime DOB,
            String Gender,
            String PatientType,
            String MaritialStatus,
            String BloodGroup,
            byte[] Image,
            int Mode)
        {
            try
            {
                bool result = false;
                int conn = pc.PatientTable(PatientId,VisitorNo,Title,PatientName,Address,ContactNo,DOB,
                    Gender,PatientType,MaritialStatus,BloodGroup,Image, Mode);
                if (conn > 0)
                    result = true;
                else
                    result = false;
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool DoctorTable(int DoctorId,
            int ReferringNo,
            String FirstName,
            String LastName,
            String Speciality,
            int ContactNo,
            DateTime DOB,
            String Gender,
            String Address,
            int ReferringRate,
            String BloodGroup,
            byte[] Image,
            int Mode)
        {
            try
            {
                bool result = false;
                int conn = dc.DoctorTable(DoctorId,ReferringNo,FirstName,LastName,Speciality,ContactNo,DOB,
                 Gender,Address,ReferringRate, BloodGroup, Image, Mode);
                if (conn > 0)
                    result = true;
                else
                    result = false;
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool MedicinesTable(int MedicineId,
            int VisitorNo,
            String PatientName,
            String DoctorName,
            String ReferredMedicines,
            DateTime MfgDate,
            DateTime ExpiredDate,
            String SupplierName,
            String CompanyName,
            int Mode)
        {
            try
            {
                bool result = false;
                int conn = mc.MedicinesTable(MedicineId, VisitorNo,PatientName,DoctorName,ReferredMedicines,MfgDate,
                   ExpiredDate,SupplierName,CompanyName, Mode);
                if (conn > 0)
                    result = true;
                else
                    result = false;
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool SaleTable(int SaleId,
           int VisitorNo,
            String PatientName,
            String DoctorName,
            String ReferredMedicines,
            Double SalesPrice,
            int Quantity,
            Double TotalPrice,
            Double Discount,
            Double GrandTotal,
            int Mode)
        {
            try
            {
                bool result = false;
                int conn = sc.SaleTable(SaleId, VisitorNo, PatientName,  DoctorName, ReferredMedicines, SalesPrice,Quantity,
                    TotalPrice, Discount, GrandTotal, Mode);
                if (conn > 0)
                    result = true;
                else
                    result = false;
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool StaffTable(int StaffId,
            int StaffNo,
            String StaffName,
            String Category,
            int WardNo,
            String Qualification,
            DateTime DOB,
            String Gender,
            String MaritalStatus,
            String BloodGroup,
            DateTime DutyTime,
            DateTime EndTime,
            byte[] Image,
            int Mode)
        {
            try
            {
                bool result = false;
                int conn = stc.StaffTable(StaffId,StaffNo,StaffName,Category,WardNo,Qualification,DOB,
                    Gender, MaritalStatus,BloodGroup,DutyTime,EndTime,Image, Mode);
                if (conn > 0)
                    result = true;
                else
                    result = false;
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool CabinTable(int CabinId,
            int CabinNo,
            int RoomNo,
            String CabinType,
            String Doctor,
            String Staff,
            int Mode)
        {
            try
            {
                bool result = false;
                int conn = cc.CabinTable(CabinId,CabinNo,RoomNo,CabinType,Doctor,Staff, Mode);
                if (conn > 0)
                    result = true;
                else
                    result = false;
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool Others(int Id,
                String AmbulanceDriver,
                int Contact,
                int Doctorsfee,
                int Staffsfee,
                DateTime Date,
            int Mode)
        {
            try
            {
                bool result = false;
                int conn = o.Others(Id, AmbulanceDriver, Contact, Doctorsfee, Staffsfee, Date, Mode);
                if (conn > 0)
                    result = true;
                else
                    result = false;
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
