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
 * Do not modify this file. This file is generated from the codecommit-2015-04-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// Returns information about a specific approval on a pull request.
    /// </summary>
    public partial class Approval
    {
        private ApprovalState _approvalState;
        private string _userArn;

        /// <summary>
        /// Gets and sets the property ApprovalState. 
        /// <para>
        /// The state of the approval, APPROVE or REVOKE. REVOKE states are not stored.
        /// </para>
        /// </summary>
        public ApprovalState ApprovalState
        {
            get { return this._approvalState; }
            set { this._approvalState = value; }
        }

        // Check to see if ApprovalState property is set
        internal bool IsSetApprovalState()
        {
            return this._approvalState != null;
        }

        /// <summary>
        /// Gets and sets the property UserArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user.
        /// </para>
        /// </summary>
        public string UserArn
        {
            get { return this._userArn; }
            set { this._userArn = value; }
        }

        // Check to see if UserArn property is set
        internal bool IsSetUserArn()
        {
            return this._userArn != null;
        }

    }
}