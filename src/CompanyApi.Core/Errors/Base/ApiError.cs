﻿namespace CompanyApi.Core.Errors.Base
{
	public class ApiError
	{
		public ApiError(int statusCode, string statusDescription)
		{
			StatusCode = statusCode;
			StatusDescription = statusDescription;
		}

		public ApiError(int statusCode, string statusDescription, string message)
			: this(statusCode, statusDescription)
		{
			Message = message;
		}

		public string Message { get; private set; }

		public int StatusCode { get; }

		public string StatusDescription { get; }
	}
}