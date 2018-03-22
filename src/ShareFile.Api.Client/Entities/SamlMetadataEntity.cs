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
using ShareFile.Api.Client;
using ShareFile.Api.Client.Extensions;
using ShareFile.Api.Client.Models;
using ShareFile.Api.Client.Requests;


namespace ShareFile.Api.Client.Entities
{
    public interface ISamlMetadataEntity : IEntityBase
    {
        IQuery GetSamlMetadata();
    }

    public class SamlMetadataEntity : EntityBase, ISamlMetadataEntity
    {
        public SamlMetadataEntity (IShareFileClient client)
            : base (client, "SamlMetadata")
        { }
        
        public IQuery GetSamlMetadata()
        {
            var sfApiQuery = new ShareFile.Api.Client.Requests.Query(Client);
            sfApiQuery.From("saml");
            sfApiQuery.Action("metadata");
            sfApiQuery.HttpMethod = "GET";	
            return sfApiQuery;
        }
    }
}