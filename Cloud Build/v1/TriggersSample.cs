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
//     Build date: 07/06/2017 15:31:14
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------  
// About 
// 
// Unoffical sample for the Cloudbuild v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Builds container images in the cloud.
// API Documentation Link https://cloud.google.com/container-builder/docs/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Cloudbuild/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Cloudbuild.v1/ 
// Install Command: PM>  Install-Package Google.Apis.Cloudbuild.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.Cloudbuild.v1;
using Google.Apis.Cloudbuild.v1.Data;
using System;

namespace GoogleSamplecSharpSample.Cloudbuildv1.Methods
{
  
    public static class TriggersSample
    {


        /// <summary>
        /// Deletes an BuildTrigger by its project ID and trigger ID.This API is experimental. 
        /// Documentation https://developers.google.com/cloudbuild/v1/reference/triggers/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudbuild service.</param>  
        /// <param name="projectId">ID of the project that owns the trigger.</param>
        /// <param name="triggerId">ID of the BuildTrigger to delete.</param>
        /// <returns>EmptyResponse</returns>
        public static Empty Delete(CloudbuildService service, string projectId, string triggerId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (projectId == null)
                    throw new ArgumentNullException(projectId);
                if (triggerId == null)
                    throw new ArgumentNullException(triggerId);

                // Make the request.
                return service.Triggers.Delete(projectId, triggerId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Triggers.Delete failed.", ex);
            }
        }

        /// <summary>
        /// Updates an BuildTrigger by its project ID and trigger ID.This API is experimental. 
        /// Documentation https://developers.google.com/cloudbuild/v1/reference/triggers/patch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudbuild service.</param>  
        /// <param name="projectId">ID of the project that owns the trigger.</param>
        /// <param name="triggerId">ID of the BuildTrigger to update.</param>
        /// <param name="body">A valid Cloudbuild v1 body.</param>
        /// <returns>BuildTriggerResponse</returns>
        public static BuildTrigger Patch(CloudbuildService service, string projectId, string triggerId, BuildTrigger body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (projectId == null)
                    throw new ArgumentNullException(projectId);
                if (triggerId == null)
                    throw new ArgumentNullException(triggerId);

                // Make the request.
                return service.Triggers.Patch(body, projectId, triggerId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Triggers.Patch failed.", ex);
            }
        }

        /// <summary>
        /// Lists existing BuildTrigger.This API is experimental. 
        /// Documentation https://developers.google.com/cloudbuild/v1/reference/triggers/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudbuild service.</param>  
        /// <param name="projectId">ID of the project for which to list BuildTriggers.</param>
        /// <returns>ListBuildTriggersResponseResponse</returns>
        public static ListBuildTriggersResponse List(CloudbuildService service, string projectId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (projectId == null)
                    throw new ArgumentNullException(projectId);

                // Make the request.
                return service.Triggers.List(projectId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Triggers.List failed.", ex);
            }
        }

        /// <summary>
        /// Gets information about a BuildTrigger.This API is experimental. 
        /// Documentation https://developers.google.com/cloudbuild/v1/reference/triggers/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudbuild service.</param>  
        /// <param name="projectId">ID of the project that owns the trigger.</param>
        /// <param name="triggerId">ID of the BuildTrigger to get.</param>
        /// <returns>BuildTriggerResponse</returns>
        public static BuildTrigger Get(CloudbuildService service, string projectId, string triggerId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (projectId == null)
                    throw new ArgumentNullException(projectId);
                if (triggerId == null)
                    throw new ArgumentNullException(triggerId);

                // Make the request.
                return service.Triggers.Get(projectId, triggerId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Triggers.Get failed.", ex);
            }
        }

        /// <summary>
        /// Creates a new BuildTrigger.This API is experimental. 
        /// Documentation https://developers.google.com/cloudbuild/v1/reference/triggers/create
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudbuild service.</param>  
        /// <param name="projectId">ID of the project for which to configure automatic builds.</param>
        /// <param name="body">A valid Cloudbuild v1 body.</param>
        /// <returns>BuildTriggerResponse</returns>
        public static BuildTrigger Create(CloudbuildService service, string projectId, BuildTrigger body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (projectId == null)
                    throw new ArgumentNullException(projectId);

                // Make the request.
                return service.Triggers.Create(body, projectId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Triggers.Create failed.", ex);
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