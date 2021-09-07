﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.OData.Builder;
using System.Web.Http.OData.Extensions;
//using Microsoft.AspNetCore.Cors;
//using Microsoft.AspNetCore.Cors;
using System.Web.Http.Cors;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;
using schools.Models;

namespace schools
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //var cors = new EnableCorsAttribute("http://localhost:4200", "*", "*");
            //config.EnableCors(cors);
            //Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //var cors = new EnableCorsAttribute("http://localhost:4200", "*", "*");
            //config.EnableCors(cors);

            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));


            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<Page>("Pages");
            builder.EntitySet<PageHistory>("PageHistories");
            builder.EntitySet<PhotoGallery>("PhotoGalleries");
            builder.EntitySet<Message>("Messages");
            builder.EntitySet<FilesNPhoto>("FilesNPhotoes");
            builder.EntitySet<MasterData>("MasterDatas");
            builder.EntitySet<ClassFee>("ClassFees");
            builder.EntitySet<Student>("Students");
            builder.EntitySet<StudentClass>("StudentClasses");
            //builder.EntitySet<StudentFeePayment>("StudentFeePayments");
            builder.EntitySet<StudentFeeReceipt>("StudentFeeReceipts");
            builder.EntitySet<StudentDocument>("StudentDocuments");
            builder.EntitySet<TaskConfiguration>("TaskConfigurations");
            builder.EntitySet<AppUser>("AppUsers");
            builder.EntitySet<RoleUser>("RoleUsers");
            builder.EntitySet<Attendance>("Attendances");
            builder.EntitySet<Organization>("Organizations");            
            builder.EntitySet<ClassSubject>("ClassSubjects");
            builder.EntitySet<Exam>("Exams");            
            builder.EntitySet<ExamSlot>("ExamSlots");
            builder.EntitySet<SlotAndClassSubject>("SlotAndClassSubjects");
            builder.EntitySet<StudentClassSubject>("StudentClassSubjects");
            builder.EntitySet<StudentActivity>("StudentActivities");
            builder.EntitySet<SubjectType>("SubjectTypes");
            builder.EntitySet<ClassSubjectMarkComponent>("ClassSubjectMarkComponents");
            builder.EntitySet<ExamStudentResult>("ExamStudentResults");
            builder.EntitySet<ExamStudentSubjectResult>("ExamStudentSubjectResults");
            builder.EntitySet<Batch>("Batches");
            builder.EntitySet<StudentCertificate>("StudentCertificates");
            builder.EntitySet<ApplicationFeature>("ApplicationFeatures");
            builder.EntitySet<ApplicationFeatureRolesPerm>("ApplicationFeatureRolesPerms");
            
            builder.EntitySet<EmpEmployee>("EmpEmployees");
            builder.EntitySet<EmpEmployeeSkill>("EmpEmployeeSkills");
            builder.EntitySet<EmployeeFamily>("EmployeeFamilies");
            builder.EntitySet<LeaveEmployeeLeaf>("LeaveEmployeeLeaves");
            builder.EntitySet<EmployeeMonthlySalary>("EmployeeMonthlySalaries");
            builder.EntitySet<EmpEmployeeSalaryComponent>("EmpEmployeeSalaryComponents");
            builder.EntitySet<EmpComponent>("EmpComponents");
            builder.EntitySet<EmpEmployeeSkill>("EmpEmployeeSkills");
            builder.EntitySet<EmployeeEducationHistory>("EmployeeEducationHistories");
            builder.EntitySet<LeaveEmployeeLeaf>("LeaveEmployeeLeaves");
            builder.EntitySet<EmpEmployeeGradeSalHistory>("EmpEmployeeGradeSalHistories");
            builder.EntitySet<VariableConfiguration>("VariableConfigurations");
            builder.EntitySet<EmpHolidayList>("EmpHolidayLists");
            builder.EntitySet<EmpManagerGroupMapping>("EmpManagerGroupMappings");
            builder.EntitySet<EmpEmployeeGroup>("EmpEmployeeGroups");
            builder.EntitySet<StudTeacherClassMapping>("StudTeacherClassMappings");
            builder.EntitySet<AccountingVoucher>("AccountingVouchers");
            builder.EntitySet<AccountingLedgerTrialBalance>("AccountingLedgerTrialBalances");
            builder.EntitySet<SchoolFeeType>("SchoolFeeTypes");
            builder.EntitySet<SchoolClassPeriod>("SchoolClassPeriods");
            builder.EntitySet<SchoolTimeTable>("SchoolTimeTables");
            builder.EntitySet<TaskAssignment>("TaskAssignments");
            builder.EntitySet<TaskAssignmentComment>("TaskAssignmentComments");
            builder.EntitySet<LeaveBalance>("LeaveBalances");
            builder.EntitySet<MasterData>("MasterDatas");
            builder.EntitySet<AttendanceReport>("AttendanceReports");
            builder.EntitySet<LeavePolicy>("LeavePolicies");
            builder.EntitySet<AspNetRole>("AspNetRoles");
            builder.EntitySet<AspNetUser>("AspNetUsers");
            builder.EntitySet<AspNetUserClaim>("AspNetUserClaims");
            builder.EntitySet<AspNetUserLogin>("AspNetUserLogins");
            builder.EntitySet<ReportConfigData>("ReportConfigDatas");
            builder.EntitySet<ReportOrgReportName>("ReportOrgReportNames");
            builder.EntitySet<ReportOrgReportColumn>("ReportOrgReportColumns");

            builder.EntitySet<ApplicationPrice>("ApplicationPrices");
            builder.EntitySet<InventoryItem>("InventoryItems");
            builder.EntitySet<CustomerInvoice>("CustomerInvoices");            
            builder.EntitySet<CustomerInvoiceItem>("CustomerInvoiceItems");
            builder.EntitySet<CustomerApp>("CustomerApps");

            config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());


            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new System.Net.Http.Headers.MediaTypeHeaderValue("application/json"));

            var json = config.Formatters.JsonFormatter;
            json.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.None;

            config.Formatters.Remove(config.Formatters.XmlFormatter);

           

        }
    }
}
