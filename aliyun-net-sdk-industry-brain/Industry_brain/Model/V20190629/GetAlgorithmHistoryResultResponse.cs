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
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.industry_brain.Model.V20190629
{
	public class GetAlgorithmHistoryResultResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private string traceId;

		private List<GetAlgorithmHistoryResult_Region> data;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public string TraceId
		{
			get
			{
				return traceId;
			}
			set	
			{
				traceId = value;
			}
		}

		public List<GetAlgorithmHistoryResult_Region> Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class GetAlgorithmHistoryResult_Region
		{

			private string output;

			private string input;

			private string invokeTime;

			public string Output
			{
				get
				{
					return output;
				}
				set	
				{
					output = value;
				}
			}

			public string Input
			{
				get
				{
					return input;
				}
				set	
				{
					input = value;
				}
			}

			public string InvokeTime
			{
				get
				{
					return invokeTime;
				}
				set	
				{
					invokeTime = value;
				}
			}
		}
	}
}
