﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

// 
// This source code was auto-generated by wsdl, Version=4.0.30319.33440.
// 

namespace UpdateNIID.Data
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name = "ServiceSoap", Namespace = "http://hts.org/")]
    public partial class Service : System.Web.Services.Protocols.SoapHttpClientProtocol
    {

        private System.Threading.SendOrPostCallback Vehicle_Policy_PushOperationCompleted;

        private System.Threading.SendOrPostCallback Marine_Policy_PushOperationCompleted;

        private System.Threading.SendOrPostCallback Vehicle_Policy_CancelOperationCompleted;

        /// <remarks/>
        public Service()
        {
            this.Url = "https://www.niid.org/NIA_API/Service.asmx";
        }

        /// <remarks/>
        public event Vehicle_Policy_PushCompletedEventHandler Vehicle_Policy_PushCompleted;

        /// <remarks/>
        public event Marine_Policy_PushCompletedEventHandler Marine_Policy_PushCompleted;

        /// <remarks/>
        public event Vehicle_Policy_CancelCompletedEventHandler Vehicle_Policy_CancelCompleted;

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://hts.org/Vehicle_Policy_Push", RequestNamespace = "http://hts.org/", ResponseNamespace = "http://hts.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string Vehicle_Policy_Push(
                    string Username,
                    string Password,
                    string NiaNaicomID,
                    string PolicyNo,
                    string InsuredName,
                    string ContactAddress,
                    string GSMNo,
                    string Email,
                    string EffectiveCoverDate,
                    string ExpirationDate,
                    string TypeOfCover,
                    string VehicleCategory,
                    string EngineNo,
                    string ChasisNo,
                    string VehicleColor,
                    string YearofMake,
                    string VehicleMake,
                    string RegistrationNo,
                    string OldRegistrationNo,
                    string VehicleType,
                    string EngineCapacity,
                    string VehicleModel,
                    double SumAssured,
                    double Premium,
                    string CoverNoteNo,
                    string CertificateNo,
                    string GeographicalZone)
        {
            object[] results = this.Invoke("Vehicle_Policy_Push", new object[] {
                    Username,
                    Password,
                    NiaNaicomID,
                    PolicyNo,
                    InsuredName,
                    ContactAddress,
                    GSMNo,
                    Email,
                    EffectiveCoverDate,
                    ExpirationDate,
                    TypeOfCover,
                    VehicleCategory,
                    EngineNo,
                    ChasisNo,
                    VehicleColor,
                    YearofMake,
                    VehicleMake,
                    RegistrationNo,
                    OldRegistrationNo,
                    VehicleType,
                    EngineCapacity,
                    VehicleModel,
                    SumAssured,
                    Premium,
                    CoverNoteNo,
                    CertificateNo,
                    GeographicalZone});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginVehicle_Policy_Push(
                    string Username,
                    string Password,
                    string NiaNaicomID,
                    string PolicyNo,
                    string InsuredName,
                    string ContactAddress,
                    string GSMNo,
                    string Email,
                    string EffectiveCoverDate,
                    string ExpirationDate,
                    string TypeOfCover,
                    string VehicleCategory,
                    string EngineNo,
                    string ChasisNo,
                    string VehicleColor,
                    string YearofMake,
                    string VehicleMake,
                    string RegistrationNo,
                    string OldRegistrationNo,
                    string VehicleType,
                    string EngineCapacity,
                    string VehicleModel,
                    double SumAssured,
                    double Premium,
                    string CoverNoteNo,
                    string CertificateNo,
                    string GeographicalZone,
                    System.AsyncCallback callback,
                    object asyncState)
        {
            return this.BeginInvoke("Vehicle_Policy_Push", new object[] {
                    Username,
                    Password,
                    NiaNaicomID,
                    PolicyNo,
                    InsuredName,
                    ContactAddress,
                    GSMNo,
                    Email,
                    EffectiveCoverDate,
                    ExpirationDate,
                    TypeOfCover,
                    VehicleCategory,
                    EngineNo,
                    ChasisNo,
                    VehicleColor,
                    YearofMake,
                    VehicleMake,
                    RegistrationNo,
                    OldRegistrationNo,
                    VehicleType,
                    EngineCapacity,
                    VehicleModel,
                    SumAssured,
                    Premium,
                    CoverNoteNo,
                    CertificateNo,
                    GeographicalZone}, callback, asyncState);
        }

        /// <remarks/>
        public string EndVehicle_Policy_Push(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void Vehicle_Policy_PushAsync(
                    string Username,
                    string Password,
                    string NiaNaicomID,
                    string PolicyNo,
                    string InsuredName,
                    string ContactAddress,
                    string GSMNo,
                    string Email,
                    string EffectiveCoverDate,
                    string ExpirationDate,
                    string TypeOfCover,
                    string VehicleCategory,
                    string EngineNo,
                    string ChasisNo,
                    string VehicleColor,
                    string YearofMake,
                    string VehicleMake,
                    string RegistrationNo,
                    string OldRegistrationNo,
                    string VehicleType,
                    string EngineCapacity,
                    string VehicleModel,
                    double SumAssured,
                    double Premium,
                    string CoverNoteNo,
                    string CertificateNo,
                    string GeographicalZone)
        {
            this.Vehicle_Policy_PushAsync(Username, Password, NiaNaicomID, PolicyNo, InsuredName, ContactAddress, GSMNo, Email, EffectiveCoverDate, ExpirationDate, TypeOfCover, VehicleCategory, EngineNo, ChasisNo, VehicleColor, YearofMake, VehicleMake, RegistrationNo, OldRegistrationNo, VehicleType, EngineCapacity, VehicleModel, SumAssured, Premium, CoverNoteNo, CertificateNo, GeographicalZone, null);
        }

        /// <remarks/>
        public void Vehicle_Policy_PushAsync(
                    string Username,
                    string Password,
                    string NiaNaicomID,
                    string PolicyNo,
                    string InsuredName,
                    string ContactAddress,
                    string GSMNo,
                    string Email,
                    string EffectiveCoverDate,
                    string ExpirationDate,
                    string TypeOfCover,
                    string VehicleCategory,
                    string EngineNo,
                    string ChasisNo,
                    string VehicleColor,
                    string YearofMake,
                    string VehicleMake,
                    string RegistrationNo,
                    string OldRegistrationNo,
                    string VehicleType,
                    string EngineCapacity,
                    string VehicleModel,
                    double SumAssured,
                    double Premium,
                    string CoverNoteNo,
                    string CertificateNo,
                    string GeographicalZone,
                    object userState)
        {
            if ((this.Vehicle_Policy_PushOperationCompleted == null))
            {
                this.Vehicle_Policy_PushOperationCompleted = new System.Threading.SendOrPostCallback(this.OnVehicle_Policy_PushOperationCompleted);
            }
            this.InvokeAsync("Vehicle_Policy_Push", new object[] {
                    Username,
                    Password,
                    NiaNaicomID,
                    PolicyNo,
                    InsuredName,
                    ContactAddress,
                    GSMNo,
                    Email,
                    EffectiveCoverDate,
                    ExpirationDate,
                    TypeOfCover,
                    VehicleCategory,
                    EngineNo,
                    ChasisNo,
                    VehicleColor,
                    YearofMake,
                    VehicleMake,
                    RegistrationNo,
                    OldRegistrationNo,
                    VehicleType,
                    EngineCapacity,
                    VehicleModel,
                    SumAssured,
                    Premium,
                    CoverNoteNo,
                    CertificateNo,
                    GeographicalZone}, this.Vehicle_Policy_PushOperationCompleted, userState);
        }

        private void OnVehicle_Policy_PushOperationCompleted(object arg)
        {
            if ((this.Vehicle_Policy_PushCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Vehicle_Policy_PushCompleted(this, new Vehicle_Policy_PushCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://hts.org/Marine_Policy_Push", RequestNamespace = "http://hts.org/", ResponseNamespace = "http://hts.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string Marine_Policy_Push(
                    string Username,
                    string Password,
                    string NiaNaicomID,
                    string CustomerCategoryId,
                    string PolicyNo,
                    string CertificateNo,
                    string ProformaInvoice,
                    string ClientName,
                    string ClientAddress,
                    string ClientMobile,
                    string ClientEmail,
                    string InceptionDate,
                    string MarinePolicyTypeId,
                    string CoverTypeId,
                    string CargoDescription,
                    string PackingTypeId,
                    string BankName,
                    string Premium,
                    string SumInsured,
                    string WarAndStrikeRate,
                    string BasicRate,
                    string TotalRate,
                    string Conditions,
                    string SailingFrom,
                    string SailingTo,
                    string VesselName,
                    string Excess,
                    string InvoicedValue,
                    string CargoCurrencyTypeId,
                    string Coinsurance)
        {
            object[] results = this.Invoke("Marine_Policy_Push", new object[] {
                    Username,
                    Password,
                    NiaNaicomID,
                    CustomerCategoryId,
                    PolicyNo,
                    CertificateNo,
                    ProformaInvoice,
                    ClientName,
                    ClientAddress,
                    ClientMobile,
                    ClientEmail,
                    InceptionDate,
                    MarinePolicyTypeId,
                    CoverTypeId,
                    CargoDescription,
                    PackingTypeId,
                    BankName,
                    Premium,
                    SumInsured,
                    WarAndStrikeRate,
                    BasicRate,
                    TotalRate,
                    Conditions,
                    SailingFrom,
                    SailingTo,
                    VesselName,
                    Excess,
                    InvoicedValue,
                    CargoCurrencyTypeId,
                    Coinsurance});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginMarine_Policy_Push(
                    string Username,
                    string Password,
                    string NiaNaicomID,
                    string CustomerCategoryId,
                    string PolicyNo,
                    string CertificateNo,
                    string ProformaInvoice,
                    string ClientName,
                    string ClientAddress,
                    string ClientMobile,
                    string ClientEmail,
                    string InceptionDate,
                    string MarinePolicyTypeId,
                    string CoverTypeId,
                    string CargoDescription,
                    string PackingTypeId,
                    string BankName,
                    string Premium,
                    string SumInsured,
                    string WarAndStrikeRate,
                    string BasicRate,
                    string TotalRate,
                    string Conditions,
                    string SailingFrom,
                    string SailingTo,
                    string VesselName,
                    string Excess,
                    string InvoicedValue,
                    string CargoCurrencyTypeId,
                    string Coinsurance,
                    System.AsyncCallback callback,
                    object asyncState)
        {
            return this.BeginInvoke("Marine_Policy_Push", new object[] {
                    Username,
                    Password,
                    NiaNaicomID,
                    CustomerCategoryId,
                    PolicyNo,
                    CertificateNo,
                    ProformaInvoice,
                    ClientName,
                    ClientAddress,
                    ClientMobile,
                    ClientEmail,
                    InceptionDate,
                    MarinePolicyTypeId,
                    CoverTypeId,
                    CargoDescription,
                    PackingTypeId,
                    BankName,
                    Premium,
                    SumInsured,
                    WarAndStrikeRate,
                    BasicRate,
                    TotalRate,
                    Conditions,
                    SailingFrom,
                    SailingTo,
                    VesselName,
                    Excess,
                    InvoicedValue,
                    CargoCurrencyTypeId,
                    Coinsurance}, callback, asyncState);
        }

        /// <remarks/>
        public string EndMarine_Policy_Push(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void Marine_Policy_PushAsync(
                    string Username,
                    string Password,
                    string NiaNaicomID,
                    string CustomerCategoryId,
                    string PolicyNo,
                    string CertificateNo,
                    string ProformaInvoice,
                    string ClientName,
                    string ClientAddress,
                    string ClientMobile,
                    string ClientEmail,
                    string InceptionDate,
                    string MarinePolicyTypeId,
                    string CoverTypeId,
                    string CargoDescription,
                    string PackingTypeId,
                    string BankName,
                    string Premium,
                    string SumInsured,
                    string WarAndStrikeRate,
                    string BasicRate,
                    string TotalRate,
                    string Conditions,
                    string SailingFrom,
                    string SailingTo,
                    string VesselName,
                    string Excess,
                    string InvoicedValue,
                    string CargoCurrencyTypeId,
                    string Coinsurance)
        {
            this.Marine_Policy_PushAsync(Username, Password, NiaNaicomID, CustomerCategoryId, PolicyNo, CertificateNo, ProformaInvoice, ClientName, ClientAddress, ClientMobile, ClientEmail, InceptionDate, MarinePolicyTypeId, CoverTypeId, CargoDescription, PackingTypeId, BankName, Premium, SumInsured, WarAndStrikeRate, BasicRate, TotalRate, Conditions, SailingFrom, SailingTo, VesselName, Excess, InvoicedValue, CargoCurrencyTypeId, Coinsurance, null);
        }

        /// <remarks/>
        public void Marine_Policy_PushAsync(
                    string Username,
                    string Password,
                    string NiaNaicomID,
                    string CustomerCategoryId,
                    string PolicyNo,
                    string CertificateNo,
                    string ProformaInvoice,
                    string ClientName,
                    string ClientAddress,
                    string ClientMobile,
                    string ClientEmail,
                    string InceptionDate,
                    string MarinePolicyTypeId,
                    string CoverTypeId,
                    string CargoDescription,
                    string PackingTypeId,
                    string BankName,
                    string Premium,
                    string SumInsured,
                    string WarAndStrikeRate,
                    string BasicRate,
                    string TotalRate,
                    string Conditions,
                    string SailingFrom,
                    string SailingTo,
                    string VesselName,
                    string Excess,
                    string InvoicedValue,
                    string CargoCurrencyTypeId,
                    string Coinsurance,
                    object userState)
        {
            if ((this.Marine_Policy_PushOperationCompleted == null))
            {
                this.Marine_Policy_PushOperationCompleted = new System.Threading.SendOrPostCallback(this.OnMarine_Policy_PushOperationCompleted);
            }
            this.InvokeAsync("Marine_Policy_Push", new object[] {
                    Username,
                    Password,
                    NiaNaicomID,
                    CustomerCategoryId,
                    PolicyNo,
                    CertificateNo,
                    ProformaInvoice,
                    ClientName,
                    ClientAddress,
                    ClientMobile,
                    ClientEmail,
                    InceptionDate,
                    MarinePolicyTypeId,
                    CoverTypeId,
                    CargoDescription,
                    PackingTypeId,
                    BankName,
                    Premium,
                    SumInsured,
                    WarAndStrikeRate,
                    BasicRate,
                    TotalRate,
                    Conditions,
                    SailingFrom,
                    SailingTo,
                    VesselName,
                    Excess,
                    InvoicedValue,
                    CargoCurrencyTypeId,
                    Coinsurance}, this.Marine_Policy_PushOperationCompleted, userState);
        }

        private void OnMarine_Policy_PushOperationCompleted(object arg)
        {
            if ((this.Marine_Policy_PushCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Marine_Policy_PushCompleted(this, new Marine_Policy_PushCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://hts.org/Vehicle_Policy_Cancel", RequestNamespace = "http://hts.org/", ResponseNamespace = "http://hts.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string Vehicle_Policy_Cancel(string Username, string Password, string PolicyNo, string RegNo)
        {
            object[] results = this.Invoke("Vehicle_Policy_Cancel", new object[] {
                    Username,
                    Password,
                    PolicyNo,
                    RegNo});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginVehicle_Policy_Cancel(string Username, string Password, string PolicyNo, string RegNo, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("Vehicle_Policy_Cancel", new object[] {
                    Username,
                    Password,
                    PolicyNo,
                    RegNo}, callback, asyncState);
        }

        /// <remarks/>
        public string EndVehicle_Policy_Cancel(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void Vehicle_Policy_CancelAsync(string Username, string Password, string PolicyNo, string RegNo)
        {
            this.Vehicle_Policy_CancelAsync(Username, Password, PolicyNo, RegNo, null);
        }

        /// <remarks/>
        public void Vehicle_Policy_CancelAsync(string Username, string Password, string PolicyNo, string RegNo, object userState)
        {
            if ((this.Vehicle_Policy_CancelOperationCompleted == null))
            {
                this.Vehicle_Policy_CancelOperationCompleted = new System.Threading.SendOrPostCallback(this.OnVehicle_Policy_CancelOperationCompleted);
            }
            this.InvokeAsync("Vehicle_Policy_Cancel", new object[] {
                    Username,
                    Password,
                    PolicyNo,
                    RegNo}, this.Vehicle_Policy_CancelOperationCompleted, userState);
        }

        private void OnVehicle_Policy_CancelOperationCompleted(object arg)
        {
            if ((this.Vehicle_Policy_CancelCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Vehicle_Policy_CancelCompleted(this, new Vehicle_Policy_CancelCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        public new void CancelAsync(object userState)
        {
            base.CancelAsync(userState);
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.33440")]
    public delegate void Vehicle_Policy_PushCompletedEventHandler(object sender, Vehicle_Policy_PushCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Vehicle_Policy_PushCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal Vehicle_Policy_PushCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.33440")]
    public delegate void Marine_Policy_PushCompletedEventHandler(object sender, Marine_Policy_PushCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Marine_Policy_PushCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal Marine_Policy_PushCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.33440")]
    public delegate void Vehicle_Policy_CancelCompletedEventHandler(object sender, Vehicle_Policy_CancelCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Vehicle_Policy_CancelCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal Vehicle_Policy_CancelCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}