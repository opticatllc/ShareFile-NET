// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//     
//	   Copyright (c) 2018 Citrix ShareFile. All rights reserved.
// </auto-generated>
// ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Net;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ShareFile.Api.Client.Extensions;
using ShareFile.Api.Client.Exceptions;

namespace ShareFile.Api.Client.Models 
{
	public class SentNotification : ODataObject 
	{
		public DateTime? DateSent { get; set; }
		public string Subject { get; set; }
		public string To { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			var typedSource = source as SentNotification;
			if(typedSource != null)
			{
				DateSent = typedSource.DateSent;
				Subject = typedSource.Subject;
				To = typedSource.To;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("DateSent", out token) && token.Type != JTokenType.Null)
				{
					DateSent = (DateTime?)serializer.Deserialize(token.CreateReader(), typeof(DateTime?));
				}
				if(source.TryGetProperty("Subject", out token) && token.Type != JTokenType.Null)
				{
					Subject = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
				if(source.TryGetProperty("To", out token) && token.Type != JTokenType.Null)
				{
					To = (string)serializer.Deserialize(token.CreateReader(), typeof(string));
				}
			}
		}
	}
}