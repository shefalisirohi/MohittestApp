﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ISiteMigrationService")]
    public interface ISiteMigrationService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISiteMigrationService/GetSiteStatus", ReplyAction="http://tempuri.org/ISiteMigrationService/GetSiteStatusResponse")]
        System.Data.DataSet GetSiteStatus(int siteId, string pxEnv, string securityToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISiteMigrationService/MigrateToPX", ReplyAction="http://tempuri.org/ISiteMigrationService/MigrateToPXResponse")]
        bool MigrateToPX(int SiteId, string PxEnvironment, int EntityId, string Company, string CourseName, string Product, string Remarks, int UserId, string UserEmail, bool isExport, bool isImport, bool isRegistration, bool isPartialUpdate, int courseType, string securityToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISiteMigrationService/FtpFiles", ReplyAction="http://tempuri.org/ISiteMigrationService/FtpFilesResponse")]
        bool FtpFiles(int siteId, string PxEnv);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISiteMigrationService/FtpGraphFiles", ReplyAction="http://tempuri.org/ISiteMigrationService/FtpGraphFilesResponse")]
        void FtpGraphFiles(int siteId, string PxEnv, int entityId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISiteMigrationService/MigrateDFcontentFiles", ReplyAction="http://tempuri.org/ISiteMigrationService/MigrateDFcontentFilesResponse")]
        void MigrateDFcontentFiles(int siteId, string pxEnv);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISiteMigrationServiceChannel : WebApplication1.ServiceReference1.ISiteMigrationService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SiteMigrationServiceClient : System.ServiceModel.ClientBase<WebApplication1.ServiceReference1.ISiteMigrationService>, WebApplication1.ServiceReference1.ISiteMigrationService {
        
        public SiteMigrationServiceClient() {
        }
        
        public SiteMigrationServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SiteMigrationServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SiteMigrationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SiteMigrationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet GetSiteStatus(int siteId, string pxEnv, string securityToken) {
            return base.Channel.GetSiteStatus(siteId, pxEnv, securityToken);
        }
        
        public bool MigrateToPX(int SiteId, string PxEnvironment, int EntityId, string Company, string CourseName, string Product, string Remarks, int UserId, string UserEmail, bool isExport, bool isImport, bool isRegistration, bool isPartialUpdate, int courseType, string securityToken) {
            return base.Channel.MigrateToPX(SiteId, PxEnvironment, EntityId, Company, CourseName, Product, Remarks, UserId, UserEmail, isExport, isImport, isRegistration, isPartialUpdate, courseType, securityToken);
        }
        
        public bool FtpFiles(int siteId, string PxEnv) {
            return base.Channel.FtpFiles(siteId, PxEnv);
        }
        
        public void FtpGraphFiles(int siteId, string PxEnv, int entityId) {
            base.Channel.FtpGraphFiles(siteId, PxEnv, entityId);
        }
        
        public void MigrateDFcontentFiles(int siteId, string pxEnv) {
            base.Channel.MigrateDFcontentFiles(siteId, pxEnv);
        }
    }
}
