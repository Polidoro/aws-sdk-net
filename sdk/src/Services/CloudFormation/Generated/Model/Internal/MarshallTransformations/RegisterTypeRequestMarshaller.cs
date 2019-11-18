/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudFormation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.CloudFormation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RegisterType Request Marshaller
    /// </summary>       
    public class RegisterTypeRequestMarshaller : IMarshaller<IRequest, RegisterTypeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RegisterTypeRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RegisterTypeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudFormation");
            request.Parameters.Add("Action", "RegisterType");
            request.Parameters.Add("Version", "2010-05-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetClientRequestToken())
                {
                    request.Parameters.Add("ClientRequestToken", StringUtils.FromString(publicRequest.ClientRequestToken));
                }
                if(publicRequest.IsSetExecutionRoleArn())
                {
                    request.Parameters.Add("ExecutionRoleArn", StringUtils.FromString(publicRequest.ExecutionRoleArn));
                }
                if(publicRequest.IsSetLoggingConfig())
                {
                    if(publicRequest.LoggingConfig.IsSetLogGroupName())
                    {
                        request.Parameters.Add("LoggingConfig" + "." + "LogGroupName", StringUtils.FromString(publicRequest.LoggingConfig.LogGroupName));
                    }
                    if(publicRequest.LoggingConfig.IsSetLogRoleArn())
                    {
                        request.Parameters.Add("LoggingConfig" + "." + "LogRoleArn", StringUtils.FromString(publicRequest.LoggingConfig.LogRoleArn));
                    }
                }
                if(publicRequest.IsSetSchemaHandlerPackage())
                {
                    request.Parameters.Add("SchemaHandlerPackage", StringUtils.FromString(publicRequest.SchemaHandlerPackage));
                }
                if(publicRequest.IsSetType())
                {
                    request.Parameters.Add("Type", StringUtils.FromString(publicRequest.Type));
                }
                if(publicRequest.IsSetTypeName())
                {
                    request.Parameters.Add("TypeName", StringUtils.FromString(publicRequest.TypeName));
                }
            }
            return request;
        }
                    private static RegisterTypeRequestMarshaller _instance = new RegisterTypeRequestMarshaller();        

        internal static RegisterTypeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RegisterTypeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}