/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.R_kvstore.Model.V20150101;

namespace Aliyun.Acs.R_kvstore.Transform.V20150101
{
    public class ModifyInstanceNetExpireTimeResponseUnmarshaller
    {
        public static ModifyInstanceNetExpireTimeResponse Unmarshall(UnmarshallerContext context)
        {
			ModifyInstanceNetExpireTimeResponse modifyInstanceNetExpireTimeResponse = new ModifyInstanceNetExpireTimeResponse();

			modifyInstanceNetExpireTimeResponse.HttpResponse = context.HttpResponse;
			modifyInstanceNetExpireTimeResponse.RequestId = context.StringValue("ModifyInstanceNetExpireTime.RequestId");
			modifyInstanceNetExpireTimeResponse.InstanceId = context.StringValue("ModifyInstanceNetExpireTime.InstanceId");

			List<ModifyInstanceNetExpireTimeResponse.ModifyInstanceNetExpireTime_NetInfoItem> modifyInstanceNetExpireTimeResponse_netInfoItems = new List<ModifyInstanceNetExpireTimeResponse.ModifyInstanceNetExpireTime_NetInfoItem>();
			for (int i = 0; i < context.Length("ModifyInstanceNetExpireTime.NetInfoItems.Length"); i++) {
				ModifyInstanceNetExpireTimeResponse.ModifyInstanceNetExpireTime_NetInfoItem netInfoItem = new ModifyInstanceNetExpireTimeResponse.ModifyInstanceNetExpireTime_NetInfoItem();
				netInfoItem.DBInstanceNetType = context.StringValue("ModifyInstanceNetExpireTime.NetInfoItems["+ i +"].DBInstanceNetType");
				netInfoItem.Port = context.StringValue("ModifyInstanceNetExpireTime.NetInfoItems["+ i +"].Port");
				netInfoItem.ExpiredTime = context.StringValue("ModifyInstanceNetExpireTime.NetInfoItems["+ i +"].ExpiredTime");
				netInfoItem.ConnectionString = context.StringValue("ModifyInstanceNetExpireTime.NetInfoItems["+ i +"].ConnectionString");
				netInfoItem.IPAddress = context.StringValue("ModifyInstanceNetExpireTime.NetInfoItems["+ i +"].IPAddress");

				modifyInstanceNetExpireTimeResponse_netInfoItems.Add(netInfoItem);
			}
			modifyInstanceNetExpireTimeResponse.NetInfoItems = modifyInstanceNetExpireTimeResponse_netInfoItems;
        
			return modifyInstanceNetExpireTimeResponse;
        }
    }
}
