﻿// Copyright 2017 DAIMTO :  www.daimto.com
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
//     Template File Name:  Methodtemplate.tt
//     Build date: 01/02/2017 22:33:00
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the gmail v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Access Gmail mailboxes including sending user email.
// API Documentation Link https://developers.google.com/gmail/api/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/gmail/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.gmail.v1/ 
// Install Command: PM>  Install-Package Google.Apis.gmail.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.gmail.v1;
using Google.Apis.gmail.v1.Data;
using System;

namespace GoogleSamplecSharpSample.gmailv1.Methods
{
  
    public static class FiltersSample
    {


        /// <summary>
        /// Creates a filter. 
        /// Documentation https://developers.google.com/gmail/v1/reference/filters/create
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated gmail service.</param>  
        /// <param name="userId">User's email address. The special value "me" can be used to indicate the authenticated user.</param>
        /// <param name="body">A valid gmail v1 body.</param>
        /// <returns>FilterResponse</returns>
        public static Filter Create(gmailService service, string userId, Filter body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (userId == null)
                    throw new ArgumentNullException(userId);

                // Make the request.
                return service.Filters.Create(body, userId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Filters.Create failed.", ex);
            }
        }


        /// <summary>
        /// Deletes a filter. 
        /// Documentation https://developers.google.com/gmail/v1/reference/filters/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated gmail service.</param>  
        /// <param name="userId">User's email address. The special value "me" can be used to indicate the authenticated user.</param>
        /// <param name="id">The ID of the filter to be deleted.</param>
        public static void Delete(gmailService service, string userId, string id)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (userId == null)
                    throw new ArgumentNullException(userId);
                if (id == null)
                    throw new ArgumentNullException(id);

                // Make the request.
                return service.Filters.Delete(userId, id).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Filters.Delete failed.", ex);
            }
        }


        /// <summary>
        /// Gets a filter. 
        /// Documentation https://developers.google.com/gmail/v1/reference/filters/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated gmail service.</param>  
        /// <param name="userId">User's email address. The special value "me" can be used to indicate the authenticated user.</param>
        /// <param name="id">The ID of the filter to be fetched.</param>
        /// <returns>FilterResponse</returns>
        public static Filter Get(gmailService service, string userId, string id)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (userId == null)
                    throw new ArgumentNullException(userId);
                if (id == null)
                    throw new ArgumentNullException(id);

                // Make the request.
                return service.Filters.Get(userId, id).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Filters.Get failed.", ex);
            }
        }


        /// <summary>
        /// Lists the message filters of a Gmail user. 
        /// Documentation https://developers.google.com/gmail/v1/reference/filters/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated gmail service.</param>  
        /// <param name="userId">User's email address. The special value "me" can be used to indicate the authenticated user.</param>
        /// <returns>ListFiltersResponseResponse</returns>
        public static ListFiltersResponse List(gmailService service, string userId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (userId == null)
                    throw new ArgumentNullException(userId);

                // Make the request.
                return service.Filters.List(userId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Filters.List failed.", ex);
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