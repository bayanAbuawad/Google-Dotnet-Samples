﻿// Copyright 2017 DAIMTO ([Linda Lawton](https://twitter.com/LindaLawtonDK)) :  [www.daimto.com](http://www.daimto.com/)
//
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by DAIMTO-Google-apis-Sample-generator 1.0.0
//     Template File Name:  methodTemplate.tt
//     Build date: 07/06/2017 15:31:21
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------  
// About 
// 
// Unoffical sample for the Logging v2beta1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Writes log entries and manages your Stackdriver Logging configuration.
// API Documentation Link https://cloud.google.com/logging/docs/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Logging/v2beta1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Logging.v2beta1/ 
// Install Command: PM>  Install-Package Google.Apis.Logging.v2beta1
//
//------------------------------------------------------------------------------  
using Google.Apis.Logging.v2beta1;
using Google.Apis.Logging.v2beta1.Data;
using System;

namespace GoogleSamplecSharpSample.Loggingv2beta1.Methods
{
  
    public static class LogsSample
    {


        /// <summary>
        /// Deletes all the log entries in a log. The log reappears if it receives new entries. Log entries written shortly before the delete operation might not be deleted. 
        /// Documentation https://developers.google.com/logging/v2beta1/reference/logs/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Logging service.</param>  
        /// <param name="logName">Required. The resource name of the log to delete:"projects/[PROJECT_ID]/logs/[LOG_ID]""organizations/[ORGANIZATION_ID]/logs/[LOG_ID]""billingAccounts/[BILLING_ACCOUNT_ID]/logs/[LOG_ID]""folders/[FOLDER_ID]/logs/[LOG_ID]"[LOG_ID] must be URL-encoded. For example, "projects/my-project-id/logs/syslog", "organizations/1234567890/logs/cloudresourcemanager.googleapis.com%2Factivity". For more information about log names, see LogEntry.</param>
        /// <returns>EmptyResponse</returns>
        public static Empty Delete(LoggingService service, string logName)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (logName == null)
                    throw new ArgumentNullException(logName);

                // Make the request.
                return service.Logs.Delete(logName).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Logs.Delete failed.", ex);
            }
        }
        public class LogsListOptionalParms
        {
            /// Optional. The maximum number of results to return from this request. Non-positive values are ignored. The presence of nextPageToken in the response indicates that more results might be available.
            public int? PageSize { get; set; }  
            /// Optional. If present, then retrieve the next batch of results from the preceding call to this method. pageToken must be the value of nextPageToken from the previous response. The values of other method parameters should be identical to those in the previous call.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// Lists the logs in projects, organizations, folders, or billing accounts. Only logs that have entries are listed. 
        /// Documentation https://developers.google.com/logging/v2beta1/reference/logs/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Logging service.</param>  
        /// <param name="parent">Required. The resource name that owns the logs:"projects/[PROJECT_ID]""organizations/[ORGANIZATION_ID]""billingAccounts/[BILLING_ACCOUNT_ID]""folders/[FOLDER_ID]"</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ListLogsResponseResponse</returns>
        public static ListLogsResponse List(LoggingService service, string parent, LogsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (parent == null)
                    throw new ArgumentNullException(parent);

                // Building the initial request.
                var request = service.Logs.List(parent);

                // Applying optional parameters to the request.                
                request = (LogsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Logs.List failed.", ex);
            }
        }
        
        }

        public static class SampleHelpers
        {

        /// <summary>
        /// Using reflection to apply optional parameters to the request.  
        /// 
        /// If the optonal parameters are null then we will just return the request as is.
        /// </summary>
        /// <param name="request">The request. </param>
        /// <param name="optional">The optional parameters. </param>
        /// <returns></returns>
        public static object ApplyOptionalParms(object request, object optional)
        {
            if (optional == null)
                return request;

            System.Reflection.PropertyInfo[] optionalProperties = (optional.GetType()).GetProperties();

            foreach (System.Reflection.PropertyInfo property in optionalProperties)
            {
                // Copy value from optional parms to the request.  They should have the same names and datatypes.
                System.Reflection.PropertyInfo piShared = (request.GetType()).GetProperty(property.Name);
				if (property.GetValue(optional, null) != null) // TODO Test that we do not add values for items that are null
					piShared.SetValue(request, property.GetValue(optional, null), null);
            }

            return request;
        }
    }
}