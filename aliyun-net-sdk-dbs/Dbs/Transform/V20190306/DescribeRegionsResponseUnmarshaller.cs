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
using Aliyun.Acs.Dbs.Model.V20190306;

namespace Aliyun.Acs.Dbs.Transform.V20190306
{
    public class DescribeRegionsResponseUnmarshaller
    {
        public static DescribeRegionsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRegionsResponse describeRegionsResponse = new DescribeRegionsResponse();

			describeRegionsResponse.HttpResponse = context.HttpResponse;
			describeRegionsResponse.Success = context.BooleanValue("DescribeRegions.Success");
			describeRegionsResponse.ErrCode = context.StringValue("DescribeRegions.ErrCode");
			describeRegionsResponse.ErrMessage = context.StringValue("DescribeRegions.ErrMessage");
			describeRegionsResponse.HttpStatusCode = context.IntegerValue("DescribeRegions.HttpStatusCode");
			describeRegionsResponse.RequestId = context.StringValue("DescribeRegions.RequestId");

			List<string> describeRegionsResponse_regions = new List<string>();
			for (int i = 0; i < context.Length("DescribeRegions.Regions.Length"); i++) {
				describeRegionsResponse_regions.Add(context.StringValue("DescribeRegions.Regions["+ i +"]"));
			}
			describeRegionsResponse.Regions = describeRegionsResponse_regions;
        
			return describeRegionsResponse;
        }
    }
}
